﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RPM_Tool.Models
{
    public class Building
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Building")]
        public string Name { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        [ForeignKey("Landlord")]
        public int LandlordId { get; set; }
        [ForeignKey("Building_Vendor")]
        public int Building_VendorId { get; set; }
        [ForeignKey("MortgageEscrow")]
        public int MortgageEscrowId { get; set; }
        [ForeignKey("Building_Utility")]
        public int Building_UtilityId { get; set; }
        [ForeignKey("ScheduledMaintenance_Building")]
        public int ScheduledMaintenance_BuildingId { get; set; }

        public ICollection<Building_Vendor> Building_Vendors { get; set; }
        public ICollection<Building_Utility> Building_Utilities { get; set; }
        public ICollection<ScheduledMaintenance_Building> ScheduledMaintenance_Buildings  { get; set; }
    }
}
