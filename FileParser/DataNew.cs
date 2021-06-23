using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public class Cassiopeia
    {
        public Assessmentmeasurement[] AssessmentMeasurements { get; set; }
        public object InspectionName { get; set; }
        public Metadata MetaData { get; set; }
        public string ResultDataType { get; set; }
        public static Cassiopeia FromJson(string json) => JsonConvert.DeserializeObject<Cassiopeia>(json, FileParser.Converter.Settings);

    }

    public class Metadata
    {
        public string UserName { get; set; }
        public DateTime Start { get; set; }
        public object End { get; set; }
        public Applicationversion ApplicationVersion { get; set; }
    }

    public class Applicationversion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }
        public int MajorRevision { get; set; }
        public int MinorRevision { get; set; }
    }

    public class Assessmentmeasurement
    {
        public Sensortype SensorType { get; set; }
        public Cable Cable { get; set; }
        public Cableserialnumber CableSerialNumber { get; set; }
        public int CableLengthInMm { get; set; }
        public Calibrationdevice CalibrationDevice { get; set; }
        public DateTime EndDate { get; set; }
        public int Temperature { get; set; }
        public Sensormeasurement[] SensorMeasurements { get; set; }
        public string IliToolId { get; set; }
    }

    public class Sensortype
    {
        public string Name { get; set; }
        public int MinAmplitude { get; set; }
        public int MaxAmplitude { get; set; }
        public int MinReferenceAmplitude { get; set; }
        public string Info { get; set; }
        public int SensorType { get; set; }
        public string SerialNumberRegex { get; set; }
        public string SerialNumberRegexInfo { get; set; }
        public Expectationrangesrelative[] ExpectationRangesRelative { get; set; }
        public object WallEchoTofFindRange { get; set; }
        public object WallEchoTofCheckRange { get; set; }
    }

    public class Expectationrangesrelative
    {
        public int TimeOfFlightInNanoseconds { get; set; }
        public int ThresholdInDecibel { get; set; }
    }

    //public class Cable
    //{
    //    public int FrontendLogicalId { get; set; }
    //    public Sensor[] Sensors { get; set; }
    //}

    public class Sensor
    {
        public int GSN { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Mode { get; set; }
        public int Class { get; set; }
        public int Unit { get; set; }
        public int Shot { get; set; }
        public int Skid { get; set; }
        public int Spot { get; set; }
        public int DirAngle { get; set; }
        public object Element { get; set; }
        public object Body { get; set; }
    }

    public class Cableserialnumber
    {
        public int PartNumber { get; set; }
        public int CableLengthInMillimeters { get; set; }
        public int YearWeekAndCounter { get; set; }
        public bool IsEmpty { get; set; }
    }

    public class Calibrationdevice
    {
        public int SensorType { get; set; }
        public int Partnumber { get; set; }
    }

    public class Sensormeasurement
    {
        public Sensor1 Sensor { get; set; }
        public int InspectionConfigurationIndex { get; set; }
        public int CalibrationStatus { get; set; }
        public Calibrationvector CalibrationVector { get; set; }
        public int CalibrationAmplitude { get; set; }
        public Calibrationshot CalibrationShot { get; set; }
        public bool CoverageState { get; set; }
        public string SerialNumber { get; set; }
        public Expectationrange[] ExpectationRanges { get; set; }
        public object SensorDefect { get; set; }
    }

    public class Sensor1
    {
        public int GSN { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Mode { get; set; }
        public int Class { get; set; }
        public int Unit { get; set; }
        public int Shot { get; set; }
        public int Skid { get; set; }
        public int Spot { get; set; }
        public int DirAngle { get; set; }
        public object Element { get; set; }
        public object Body { get; set; }
    }

    public class Calibrationvector
    {
        public int TimeOfFlight { get; set; }
        public int AmplitudeValue { get; set; }
        public bool IsAmplitudeNegative { get; set; }
        public int Threshold { get; set; }
        public bool IsSelected { get; set; }
    }

    public class Calibrationshot
    {
        public DateTime Timestamp { get; set; }
        public Sensor2 Sensor { get; set; }
        public Shotdata ShotData { get; set; }
        public int Angle { get; set; }
    }

    public class Sensor2
    {
        public int GSN { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Mode { get; set; }
        public int Class { get; set; }
        public int Unit { get; set; }
        public int Shot { get; set; }
        public int Skid { get; set; }
        public int Spot { get; set; }
        public int DirAngle { get; set; }
        public object Element { get; set; }
        public object Body { get; set; }
    }

    public class Shotdata
    {
        public string Selections { get; set; }
        public string TimeOfFlights { get; set; }
        public int SystemFrequency { get; set; }
        public string Amplitudes { get; set; }
        public string ShotDataType { get; set; }
    }

    public class Expectationrange
    {
        public int TimeOfFlightInNanoseconds { get; set; }
        public int ThresholdInDecibel { get; set; }
    }

}
