using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prop_finder
{
    public class Property
    {

        //property_id INT PRIMARY KEY,prop_lister_email varchar(255), property_type VARCHAR(50), start_price DECIMAL(10,2),
        //end_price DECIMAL(10,2), num_rooms INT, num_bathrooms INT, city VARCHAR(50), street VARCHAR(50), building_number VARCHAR(20),
        //description VARCHAR(255),area DECIMAL(10,2),status Number(1), phone_number VARCHAR(20),
        //CONSTRAINT property_fk_lister_emailFOREIGN KEY(prop_lister_email)
        //REFERENCES Listers(lister_email)
        public int PropertyId { get; set; }

        public string Property_Lister_email { get; set; }
        public string Type { get; set; }
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public int NumRooms { get; set; }
        public int NumBathrooms { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string Description { get; set; }
        public decimal Area { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }

        public Property(int propertyId, string property_lister_email, string type, decimal startPrice, decimal endPrice, int numRooms, int numBathrooms, string city, string street, string buildingNumber, string description, decimal area, string status, string phoneNumber)
        {
            PropertyId = propertyId;
            Property_Lister_email = property_lister_email;
            Type = type;
            StartPrice = startPrice;
            EndPrice = endPrice;
            NumRooms = numRooms;
            NumBathrooms = numBathrooms;
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
            Description = description;
            Area = area;
            Status = status;
            PhoneNumber = phoneNumber;
        }

        public Property(string property_lister_email, string type, decimal startPrice, decimal endPrice, int numRooms, int numBathrooms, string city, string street, string buildingNumber, string description, decimal area, string status, string phoneNumber)
        {

            Property_Lister_email = property_lister_email;
            Type = type;
            StartPrice = startPrice;
            EndPrice = endPrice;
            NumRooms = numRooms;
            NumBathrooms = numBathrooms;
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
            Description = description;
            Area = area;
            Status = status;
            PhoneNumber = phoneNumber;
        }

        public Property(int propertyId)
        {
            PropertyId = propertyId;
        }
    }
    }
