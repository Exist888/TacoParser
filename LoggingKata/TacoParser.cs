﻿namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                logger.LogError("Not enough information.");
                return null; 
            }

            // TODO: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            double parsedLatitude = double.Parse(cells[0]);
            
            // double ParsedLatitude(string line)
            // {
            //     var stringArray1 = line.Split(',');
            //     var latitude = stringArray1[0];
            //     var parsedLatitude = double.Parse(latitude);
            //     return parsedLatitude;
            // }
            
            // TODO: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            double parsedLongitude = double.Parse(cells[1]);
            
            // TODO: Grab the name from your array at index 2
            string name = cells[2];

            // TODO: Create a TacoBell class
            // that conforms to ITrackable
            
            // TODO: Create an instance of the Point Struct
            // TODO: Set the values of the point correctly (Latitude and Longitude)

            Point newPoint = new Point()
            {
                Latitude = parsedLatitude,
                Longitude = parsedLongitude,
            };

            // TODO: Create an instance of the TacoBell class
            var newTacoBell = new TacoBell();
            //
            // // TODO: Set the values of the class correctly (Name and Location)
            newTacoBell.Name = name;
            newTacoBell.Location = newPoint;
            
            // TacoBell newTacoBell = new TacoBell()
            // {
            //     Location = newPoint,
            //     Name = name,
            // };

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable
            return newTacoBell;

            return null;
        }
    }
}
