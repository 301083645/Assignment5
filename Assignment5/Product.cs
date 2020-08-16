using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Product
    {
        public string ProductID { get; set; }
        public string Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RAM_type { get; set; }
        public string RAM_size { get; set; }
        public string Displaytype { get; set; }
        public string Screensize { get; set; }
        public string Resolution { get; set; }
        public string CPU_Class { get; set; }
        public string CPU_brand { get; set; }
        public string CPU_type { get; set; }
        public string CPU_speed { get; set; }
        public string CPU_number { get; set; }
        public string Condition { get; set; }
        public string OS { get; set; }
        public string Platform { get; set; }
        public string HDD_size { get; set; }
        public string HDD_speed { get; set; }
        public string GPU_Type { get; set; }
        public string Optical_drive { get; set; }
        public string Audio_type { get; set; }
        public string LAN { get; set; }
        public string WIFI { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }
        public string Moust_type { get; set; }
        public string Power { get; set; }
        public string Webcam { get; set; }
    }

    public Product(

    string _ProductID = "",
    string _Cost = "",
    string _Manufacturer = "",
    string _Model = "",
    string _RAM_type = "",
    string _RAM_size = "",
    string _Displaytype = "",
    string _Screensize = "",
    string _Resolution = "",
    string _CPU_Class = "",
    string _CPU_brand = "",
    string _CPU_type = "",
    string _CPU_speed = "",
    string _CPU_number = "",
    string _Condition = "",
    string _OS = "",
    string _Platform = "",
    string _HDD_size = "",
    string _HDD_speed = "",
    string _GPU_Type = "",
    string _Optical_drive = "",
    string _Audio_type = "",
    string _LAN = "",
    string _WIFI = "",
    string _Width = "",
    string _Height = "",
    string _Depth = "",
    string _Weight = "",
    string _Moust_type = "",
    string _Power = "",
    string _Webcam = ""

    )
    {

        ProductID = _ProductID;
        Cost = _Cost;
        Manufacturer = _Manufacturer;
        Model = _Model;
        RAM_type = _RAM_type;
        RAM_size = _RAM_size;
        Displaytype = _Displaytype;
        Screensize = _Screensize;
        Resolution = _Resolution;
        CPU_Class = _CPU_Class;
        CPU_brand = _CPU_brand;
        CPU_type = _CPU_type;
        CPU_speed = _CPU_speed;
        CPU_number = _CPU_number;
        Condition = _Condition;
        OS = _OS;
        Platform = _Platform;
        HDD_size = _HDD_size;
        HDD_speed = _HDD_speed;
        GPU_Type = _GPU_Type;
        Optical_drive = _Optical_drive;
        Audio_type = _Audio_type;
        LAN = _LAN;
        WIFI = _WIFI;
        Width = _Width;
        Height = _Height;
        Depth = _Depth;
        Weight = _Weight;
        Moust_type = _Moust_type;
        Power = _Power;
        Webcam = _Webcam;
}
}
