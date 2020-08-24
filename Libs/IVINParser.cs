using System;

namespace VIN_LIB
{
    public interface IVINParser
    {
        bool CheckVIN(String vin);
        string GetVINCountry(String vin); 
        Int32 GetTransportYear(String vin);
    }
}
