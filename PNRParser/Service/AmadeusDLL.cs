using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNRParser.Service
{
    public class AmadeusDLL
    {
        public static string GetAirlineRecord(s1aPNR.PNR objPNR, k1aHostToolKit.HostSession objSession)
        {
            string returnVal = "";

            List<string> temp = new List<string>();
            List<string> tempAirline = new List<string>();

            foreach (s1aPNR.AirSegment objSegment in objPNR.AirSegments)
            {
                if (temp.FirstOrDefault(r => r == objSegment.AirlineReference) == null || tempAirline.FirstOrDefault(r=>r==objSegment.Airline) == null)
                {
                    temp.Add(objSegment.AirlineReference);
                    tempAirline.Add(objSegment.Airline);
                }
            }

            int ctr = 0;

            temp.ForEach(x =>
            {
                if (Properties.Settings.Default.dbType == "ACCESS")
                {
                    returnVal += AccessDB.ConvertAirlineCode(tempAirline[ctr]) + " " + tempAirline[ctr] +"/" + x + "\n";
                }
                else
                {
                    returnVal += SQLServerDB.ConvertAirlineCode(tempAirline[ctr]) + " " + tempAirline[ctr] + "/" + x + "\n";
                }
                ctr++;
            });

            return returnVal;
        }

        public static string ConvertAirlineStatus(string input)
        {
            if(input.Length >= 2)
            {
                var temp = input.Substring(0, 2);

                if (temp == "HK" || temp == "RR" || temp == "TK" || temp == "KK" || temp == "GK" || temp == "DK")
                    return "OK";
                else if (temp == "HL" || temp == "GL")
                    return "WAITLISTED";
                else if (temp == "UC")
                    return "UNCONFIRMED";
                else if (temp == "HX")
                    return "CANCELLED";
            }

            return "";
        }

        public static string GetPax(s1aPNR.PNR objPNR, k1aHostToolKit.HostSession objSession)
        {
            List<string> paxes = new List<string>();
            string allPax = "";
            int ctr = 1;

            foreach (s1aPNR.NameElement name in objPNR.NameElements)
            {
                paxes.Add(name.LastName + "/" + name.Initial);
            }

            paxes.ForEach(item =>
            {
                allPax += "          " + ctr.ToString() + ". " + item + "\n";

                ctr++;
            });

            return allPax;
        }

        public static string GetPaxTicket(s1aPNR.PNR objPNR, k1aHostToolKit.HostSession objSession, MainWindow main)
        {
            try
            {
                List<string> Name = new List<string>();

                int ctr = 1;

                string returnVal = "";

                foreach (s1aPNR.NameElement paxName in objPNR.NameElements)
                {
                    Name.Add(paxName.Text);
                }

                if (Name.Count == 0)
                {
                    objSession.Send("IG");

                    main.Error("No PAX found");
                }
                else
                {
                    Name.ForEach(item =>
                    {
                        string temp = item.Substring(2, item.Length - 2);

                        string paxTemp = ctr.ToString() + "." + temp + "\n";

                        returnVal += paxTemp;

                        ctr++;
                    });
                }

                return returnVal;
            }
            catch(Exception error)
            {
                main.Error(error.Message);

                return "";
            }
        }

        private class Itinerary
        {
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string Start { get; set; }
            public string End { get; set; }
        }

        public static string GetItineraryInfo(s1aPNR.PNR objPNR, k1aHostToolKit.HostSession objSession, bool baggage)
        {
            string returnVal = "";

            int maxOrigin = 6, maxDestination = 11, maxStatus = 0;

           // List<string> Itinerary = new List<string>();

            List<Itinerary> Itineraries = new List<Itinerary>();

            var segments = objPNR.AirSegments;

            var flown = objPNR.AirFlownSegments;

            if (segments.Count() != 0)
            {
                //==================GET ITINERARY DETAILS=====================
                foreach (s1aPNR.AirSegment airSegment in segments)
                {
                    string tempFlightNo = airSegment.Airline + " " + airSegment.FlightNo;

                    string tempDate = airSegment.DepartureDate.ToString("ddMMM");

                    string tempOrigin = "";

                    string tempDestination = "";

                    if (Properties.Settings.Default.dbType == "ACCESS")
                    {
                        tempOrigin = AccessDB.ConvertCityCode(airSegment.BoardPoint) + "(" + airSegment.BoardPoint + ")";

                        tempDestination = AccessDB.ConvertCityCode(airSegment.OffPoint) + "(" + airSegment.OffPoint + ")";
                    }
                    else
                    {
                        tempOrigin += SQLServerDB.ConvertCityCode(airSegment.BoardPoint) + "(" + airSegment.BoardPoint + ")";

                        tempDestination += SQLServerDB.ConvertCityCode(airSegment.OffPoint) + "(" + airSegment.OffPoint + ")";
                    }


                    if (segments.Count() > 1)
                    {
                        if (tempDestination.Count() > tempOrigin.Count())
                        {
                            if (tempDestination.Count() > maxOrigin)
                                maxOrigin = tempDestination.Count();
                        }
                        else
                            if (tempOrigin.Count() > maxOrigin)
                                maxOrigin = tempOrigin.Count();

                        if (tempOrigin.Count() > tempDestination.Count())
                        {
                            if (tempOrigin.Count() > maxDestination)
                                maxDestination = tempOrigin.Count();
                        }
                        else
                            if (tempDestination.Count() > maxDestination)
                                maxDestination = tempDestination.Count();
                    }
                    else
                    {
                        maxOrigin = tempOrigin.Count() + 2;

                        maxDestination = tempDestination.Count() + 2;
                    }

                    string tempDepTime = airSegment.DepartureTime.ToString("Hmm");

                    string tempArrvlTime = airSegment.ArrivalTime.ToString("Hmm");

                    string tempArrvlDate = airSegment.ArrivalDate.ToString("ddMMM");

                    string tempStatus = ConvertAirlineStatus(airSegment.StatusCode);

                    string tempBaggage = "";

                    if (tempDepTime.Length == 3)
                        tempDepTime = "0" + tempDepTime;

                    if (tempArrvlTime.Length == 3)
                        tempArrvlTime = "0" + tempArrvlTime;

                    if (maxStatus < airSegment.StatusCode.Count())
                        maxStatus = airSegment.StatusCode.Count() + 2;

                    if (maxStatus < 6)
                        maxStatus = 6;

                    if (baggage)
                    {
                        tempBaggage = "40 kls";

                        Itinerary temp = new Itinerary();

                        temp.Start = tempFlightNo.PadRight(8, ' ') + tempDate.PadRight(7, ' ');

                        temp.Origin = tempOrigin;

                        temp.Destination = tempDestination;

                        temp.End = tempDepTime.PadRight(6, ' ') + tempArrvlTime.PadRight(6, ' ') +
                           tempArrvlDate.PadRight(7, ' ') + tempStatus.PadRight(maxStatus, ' ') + tempBaggage.PadRight(21, ' ');

                        Itineraries.Add(temp);

                        //Itinerary.Add(tempFlightNo.PadRight(8, ' ') + tempDate.PadRight(7, ' ') + tempOrigin.PadRight(maxOrigin + 3, ' ') +
                        //   tempDestination.PadRight(maxDestination + 3, ' ') + tempDepTime.PadRight(6, ' ') + tempArrvlTime.PadRight(6, ' ') +
                        //   tempArrvlDate.PadRight(7, ' ') + tempStatus.PadRight(maxStatus + 3, ' ') + tempBaggage.PadRight(21, ' '));
                    }
                    else
                    {
                        Itinerary temp = new Itinerary();

                        temp.Start = tempFlightNo.PadRight(8, ' ') + tempDate.PadRight(7, ' ');

                        temp.Origin = tempOrigin;

                        temp.Destination = tempDestination;

                        temp.End = tempDepTime.PadRight(6, ' ') + tempArrvlTime.PadRight(6, ' ') +
                        tempArrvlDate.PadRight(7, ' ') + tempStatus.PadRight(maxStatus, ' ');

                        Itineraries.Add(temp);

                        //Itinerary.Add(tempFlightNo.PadRight(8, ' ') + tempDate.PadRight(7, ' ') + tempOrigin.PadRight(maxOrigin + 3, ' ') +
                        //    tempDestination.PadRight(maxDestination + 3, ' ') + tempDepTime.PadRight(6, ' ') + tempArrvlTime.PadRight(6, ' ') +
                        //    tempArrvlDate.PadRight(7, ' ') + tempStatus.PadRight(maxStatus + 3, ' '));
                    }
                }
                string header = "";

                if (baggage)
                {
                    header = ("Flight").PadRight(8, ' ') + ("Date").PadRight(7, ' ') + ("Origin").PadRight(maxOrigin, ' ') +
                        ("Destination").PadRight(maxDestination, ' ') + ("Dep").PadRight(6, ' ') + ("Arrvl").PadRight(6, ' ') +
                        ("Arrvl").PadRight(7, ' ') + ("Status").PadRight(maxStatus, ' ') + ("Bag").PadRight(8, ' ');
                }
                else
                {
                    header = ("Flight").PadRight(8, ' ') + ("Date").PadRight(7, ' ') + ("Origin").PadRight(maxOrigin, ' ') +
                       ("Destination").PadRight(maxDestination, ' ') + ("Dep").PadRight(6, ' ') + ("Arrvl").PadRight(6, ' ') +
                       ("Arrvl").PadRight(7, ' ') + ("Status").PadRight(maxStatus, ' ');
                }

                int headerCount = header.Count() + 3;

                string line = "";

                for (int x = 0; x < headerCount; x++)
                {
                    line += "-";
                }

                header = line + "\n" + header + "\n" + line;

                returnVal += header + "\n";

                Itineraries.ForEach(item =>
                {
                    returnVal += item.Start + item.Origin.PadRight(maxOrigin, ' ') + item.Destination.PadRight(maxDestination, ' ') + item.End + "\n";
                });

                //Itinerary.ForEach(item =>
                //{
                //    returnVal += item + "\n";
                //});

                returnVal += line;
            }
            else if (flown.count() != 0)
            {
                returnVal = "-----------------------------------------------------------------------------------------------------------\n" +
                            "\t\t\t\t\t\t TICKET/s FLOWN\n" +
                            "-----------------------------------------------------------------------------------------------------------";
            }
            else
            {
                returnVal = "-----------------------------------------------------------------------------------------------------------\n" +
                           "\t\t\t\t\t\t NO ITINERARY\n" +
                           "------------------------------------------------------------------------------------------------------------";
            }

            return returnVal;
        }

        public static string GetContactInfo(s1aPNR.PNR objPNR, k1aHostToolKit.HostSession objSession)
        {
            string returnVal = "";

            foreach(s1aPNR.PhoneElement objPhone in objPNR.PhoneElements)
            {
                returnVal += objPhone.FreeFlow + "\n";
            }

            return returnVal;
        }

        public static string GetRemarks(s1aPNR.PNR objPNR, k1aHostToolKit.HostSession objSession)
        {
            string returnVal = "";

            foreach(s1aPNR.RemarkElement remark in objPNR.RemarkElements)
            {
                returnVal += remark.FreeFlow + "\n";
            }

            return returnVal;
        }
    }
}
