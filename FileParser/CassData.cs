using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FileParser
{
    // CassData myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class CassData
    {
        [JsonProperty("Measurements")]
        public List<Measurement> Measurements;

        [JsonProperty("AssessmentMeasurements")]
        public List<AssessmentMeasurement> AssessmentMeasurements;

        [JsonProperty("SensorCarrier")]
        public SensorCarrier SensorCarrier;

        [JsonProperty("AScanMode")]
        public int AScanMode;

        [JsonProperty("InspectionName")]
        public InspectionName InspectionName;

        [JsonProperty("MetaData")]
        public MetaData MetaData;

        [JsonProperty("ResultDataType")]
        public string ResultDataType;

        public static CassData FromJson(string json) => JsonConvert.DeserializeObject<CassData>(json, Converter.Settings);
    }
    
    public class ExpectationRangesRelative
    {
        [JsonProperty("TimeOfFlightInNanoseconds")]
        public int TimeOfFlightInNanoseconds;

        [JsonProperty("ThresholdInDecibel")]
        public int ThresholdInDecibel;
    }

    public class SensorType
    {
        [JsonProperty("Name")]
        public string Name;

        [JsonProperty("MinAmplitude")]
        public int MinAmplitude;

        [JsonProperty("MaxAmplitude")]
        public int MaxAmplitude;

        [JsonProperty("MinReferenceAmplitude")]
        public int MinReferenceAmplitude;

        [JsonProperty("Info")]
        public string Info;

        [JsonProperty("SensorType")]
        public int SensorTypeInfo;

        [JsonProperty("SerialNumberRegex")]
        public string SerialNumberRegex;

        [JsonProperty("SerialNumberRegexInfo")]
        public string SerialNumberRegexInfo;

        [JsonProperty("ExpectationRangesRelative")]
        public List<ExpectationRangesRelative> ExpectationRangesRelative;

        [JsonProperty("WallEchoTofFindRange")]
        public object WallEchoTofFindRange;

        [JsonProperty("WallEchoTofCheckRange")]
        public object WallEchoTofCheckRange;
    }

    public class AssessmentMeasurement
    {
        [JsonProperty("SensorType")]
        public SensorType SensorType;

        [JsonProperty("Cable")]
        public Cable Cable;

        [JsonProperty("CableSerialNumber")]
        public CableSerialNumber CableSerialNumber;

        [JsonProperty("CableLengthInMm")]
        public int CableLengthInMm;

        [JsonProperty("CalibrationDevice")]
        public CalibrationDevice CalibrationDevice;

        [JsonProperty("EndDate")]
        public string EndDate;

        [JsonProperty("Temperature")]
        public int Temperature;

        [JsonProperty("SensorMeasurements")]
        public List<SensorMeasurement> SensorMeasurements;

        [JsonProperty("IliToolId")]
        public string IliToolId;
    }

    public class SensorMeasurement
    {
        [JsonProperty("Sensor")]
        public Sensor Sensor;

        [JsonProperty("InspectionConfigurationIndex")]
        public int InspectionConfigurationIndex;

        [JsonProperty("CalibrationStatus")]
        public int CalibrationStatus;

        [JsonProperty("CalibrationVector")]
        public CalibrationVector CalibrationVector;

        [JsonProperty("CalibrationAmplitude")]
        public int CalibrationAmplitude;

        [JsonProperty("CalibrationShot")]
        public CalibrationShot CalibrationShot;

        [JsonProperty("CoverageState")]
        public bool CoverageState;

        [JsonProperty("SerialNumber")]
        public string SerialNumber;

        [JsonProperty("ExpectationRanges")]
        public List<ExpectationRanx> ExpectationRanges;

        [JsonProperty("SensorDefect")]
        public object SensorDefect;
    }

    public class ShotData
    {
        [JsonProperty("Selections")]
        public string Selections;

        [JsonProperty("TimeOfFlights")]
        public string TimeOfFlights;

        [JsonProperty("SystemFrequency")]
        public int SystemFrequency;

        [JsonProperty("Amplitudes")]
        public string Amplitudes;

        [JsonProperty("ShotDataType")]
        public string ShotDataType;

        [JsonProperty("VectorCount")]
        public int VectorCount;
    }

    public class Cable
    {
        [JsonProperty("FrontendLogicalId")]
        public int FrontendLogicalId;

        [JsonProperty("Sensors")]
        public List<Sensor> Sensors;
    }

    public class CalibrationDevice
    {
        [JsonProperty("SensorType")]
        public int SensorType;

        [JsonProperty("Partnumber")]
        public int Partnumber;
    }

    public class CableSerialNumber
    {
        [JsonProperty("PartNumber")]
        public int PartNumber;

        [JsonProperty("CableLengthInMillimeters")]
        public int CableLengthInMillimeters;

        [JsonProperty("YearWeekAndCounter")]
        public int YearWeekAndCounter;

        [JsonProperty("IsEmpty")]
        public bool IsEmpty;
    }
    
    public class Shot
    {
        [JsonProperty("Timestamp")]
        public string Timestamp;

        [JsonProperty("Sensor")]
        public Sensor Sensor;

        [JsonProperty("ShotData")]
        public ShotData ShotData;

        [JsonProperty("Angle")]
        public int Angle;
    }

    public class Measurement
    {
        [JsonProperty("Sensor")]
        public Sensor Sensor;

        [JsonProperty("AScanMode")]
        public int AScanMode;

        [JsonProperty("InspectionConfigurationIndex")]
        public int InspectionConfigurationIndex;

        [JsonProperty("CalibrationStatus")]
        public int CalibrationStatus;

        [JsonProperty("CalibrationAmplitude")]
        public object CalibrationAmplitude;

        [JsonProperty("Shot")]
        public Shot Shot;
    }

    public class Designation
    {
        [JsonProperty("DesignDimensionInInches")]
        public int DesignDimensionInInches;

        [JsonProperty("AdaptedDimensionInInches")]
        public int AdaptedDimensionInInches;

        [JsonProperty("NumberOfSkids")]
        public int NumberOfSkids;

        [JsonProperty("NumberOfInsertedSensorsPerSkid")]
        public int NumberOfInsertedSensorsPerSkid;

        [JsonProperty("NumberOfInsertedWtSensorsPerSkidIfCrackDetection")]
        public int NumberOfInsertedWtSensorsPerSkidIfCrackDetection;

        [JsonProperty("TechnologyAndInspectionTask")]
        public string TechnologyAndInspectionTask;

        [JsonProperty("Version")]
        public int Version;
    }

    public class GeneralInformation
    {
        [JsonProperty("Designation")]
        public Designation Designation;

        [JsonProperty("InspectionTask")]
        public int InspectionTask;

        [JsonProperty("PipeDiaInch")]
        public int PipeDiaInch;

        [JsonProperty("PipeDiaMm")]
        public int PipeDiaMm;

        [JsonProperty("Version")]
        public int Version;

        [JsonProperty("DesignSoWT")]
        public int DesignSoWT;

        [JsonProperty("DesignSoCT")]
        public int DesignSoCT;

        [JsonProperty("DesignWt")]
        public int DesignWt;

        [JsonProperty("AngleOfIncidence")]
        public int AngleOfIncidence;

        [JsonProperty("NoOfSkids")]
        public int NoOfSkids;

        [JsonProperty("NoOfSensorsTotal")]
        public int NoOfSensorsTotal;

        [JsonProperty("NoOfSpotsPerSkid")]
        public int NoOfSpotsPerSkid;

        [JsonProperty("NoOfWTSpotsPerSkid")]
        public int NoOfWTSpotsPerSkid;

        [JsonProperty("NoOfSensorsWT")]
        public int NoOfSensorsWT;

        [JsonProperty("NoOfSensorsCTCW")]
        public int NoOfSensorsCTCW;

        [JsonProperty("NoOfSensorsCTCCW")]
        public int NoOfSensorsCTCCW;

        [JsonProperty("NoOfSensorsCTDS")]
        public int NoOfSensorsCTDS;

        [JsonProperty("NoOfSensorsCTUS")]
        public int NoOfSensorsCTUS;
    }

    public class Sensor
    {
        [JsonProperty("GSN")]
        public int GSN;

        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("Mode")]
        public int Mode;

        [JsonProperty("Class")]
        public int Class;

        [JsonProperty("Unit")]
        public int Unit;

        [JsonProperty("Shot")]
        public int Shot;

        [JsonProperty("Skid")]
        public int Skid;

        [JsonProperty("Spot")]
        public int Spot;

        [JsonProperty("DirAngle")]
        public int DirAngle;

        [JsonProperty("Element")]
        public object Element;

        [JsonProperty("Body")]
        public object Body;
    }

    public class Sensor2
    {
        [JsonProperty("GSN")]
        public int GSN;

        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("Mode")]
        public int Mode;

        [JsonProperty("Class")]
        public int Class;

        [JsonProperty("Unit")]
        public int Unit;

        [JsonProperty("Shot")]
        public int Shot;

        [JsonProperty("Skid")]
        public int Skid;

        [JsonProperty("Spot")]
        public int Spot;

        [JsonProperty("DirAngle")]
        public int DirAngle;

        [JsonProperty("Element")]
        public object Element;

        [JsonProperty("Body")]
        public object Body;
    }

    public class Sensor3
    {
        [JsonProperty("GSN")]
        public int GSN;

        [JsonProperty("X")]
        public int X;

        [JsonProperty("Y")]
        public int Y;

        [JsonProperty("Mode")]
        public int Mode;

        [JsonProperty("Class")]
        public int Class;

        [JsonProperty("Unit")]
        public int Unit;

        [JsonProperty("Shot")]
        public int Shot;

        [JsonProperty("Skid")]
        public int Skid;

        [JsonProperty("Spot")]
        public int Spot;

        [JsonProperty("DirAngle")]
        public int DirAngle;

        [JsonProperty("Element")]
        public object Element;

        [JsonProperty("Body")]
        public object Body;
    }

    public class CommonFileHeader
    {
        [JsonProperty("FileDescription")]
        public string FileDescription;

        [JsonProperty("FileComment")]
        public string FileComment;

        [JsonProperty("DateTime")]
        public string DateTime;

        [JsonProperty("FileNameOrg")]
        public string FileNameOrg;
    }

    public class SensorCarrier
    {
        [JsonProperty("GeneralInformation")]
        public GeneralInformation GeneralInformation;

        [JsonProperty("Sensors")]
        public List<Sensor> Sensors;

        [JsonProperty("CommonFileHeader")]
        public CommonFileHeader CommonFileHeader;
    }

    public class CalibrationShot
    {
        [JsonProperty("Timestamp")]
        public string Timestamp;

        [JsonProperty("Sensor")]
        public Sensor Sensor;

        [JsonProperty("ShotData")]
        public ShotData ShotData;

        [JsonProperty("Angle")]
        public int Angle;
    }

    public class CalibrationVector
    {
        [JsonProperty("TimeOfFlight")]
        public int TimeOfFlight;

        [JsonProperty("AmplitudeValue")]
        public int AmplitudeValue;

        [JsonProperty("IsAmplitudeNegative")]
        public bool IsAmplitudeNegative;

        [JsonProperty("Threshold")]
        public int Threshold;

        [JsonProperty("IsSelected")]
        public bool IsSelected;
    }

    public class InspectionName
    {
        [JsonProperty("Client")]
        public string Client;

        [JsonProperty("Pipeline")]
        public string Pipeline;

        [JsonProperty("Year")]
        public int Year;

        [JsonProperty("TechnologyAndInspectionTask")]
        public string TechnologyAndInspectionTask;

        [JsonProperty("Index")]
        public int Index;
    }

    public class ExpectationRanx
    {
        [JsonProperty("TimeOfFlightInNanoseconds")]
        public int TimeOfFlightInNanoseconds;

        [JsonProperty("ThresholdInDecibel")]
        public int ThresholdInDecibel;
    }

    public class ApplicationVersion
    {
        [JsonProperty("Major")]
        public int Major;

        [JsonProperty("Minor")]
        public int Minor;

        [JsonProperty("Build")]
        public int Build;

        [JsonProperty("Revision")]
        public int Revision;

        [JsonProperty("MajorRevision")]
        public int MajorRevision;

        [JsonProperty("MinorRevision")]
        public int MinorRevision;
    }

    public class MetaData
    {
        [JsonProperty("UserName")]
        public string UserName;

        [JsonProperty("Start")]
        public string Start;

        [JsonProperty("End")]
        public string End;

        [JsonProperty("IsFinalized")]
        public bool IsFinalized;

        [JsonProperty("ApplicationVersion")]
        public ApplicationVersion ApplicationVersion;
    }

    public enum ShotDataType { NdtCassiopeiaCommonMeasurementModelsShotDataAlok };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ShotDataTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class ShotDataTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShotDataType) || t == typeof(ShotDataType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Ndt.Cassiopeia.Common.Measurement.Models.ShotDataAlok")
            {
                return ShotDataType.NdtCassiopeiaCommonMeasurementModelsShotDataAlok;
            }
            throw new Exception("Cannot unmarshal type ShotDataType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ShotDataType)untypedValue;
            if (value == ShotDataType.NdtCassiopeiaCommonMeasurementModelsShotDataAlok)
            {
                serializer.Serialize(writer, "Ndt.Cassiopeia.Common.Measurement.Models.ShotDataAlok");
                return;
            }
            throw new Exception("Cannot marshal type ShotDataType");
        }

        public static readonly ShotDataTypeConverter Singleton = new ShotDataTypeConverter();
    }
}