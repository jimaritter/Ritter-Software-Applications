﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherishedPetBoarding.Model.Common
{
    [Serializable]
    public enum States
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        [Description("Alabama")]
        AL,
        [Description("Alaska")]
        AK,
        [Description("Arizona ")]
        AZ,
        [Description("Arkansas")]
        AR,
        [Description("California ")]
        CA,
        [Description("Colorado ")]
        CO,
        [Description("Connecticut")]
        CT,
        [Description("Delaware")]
        DE,
        [Description("District Of Columbia")]
        DC,
        [Description("Florida")]
        FL,
        [Description("Georgia")]
        GA,
        [Description("Hawaii")]
        HI,
        [Description("Idaho")]
        ID,
        [Description("Illinois")]
        IL,
        [Description("Indiana")]
        IN,
        [Description("Iowa")]
        IA,
        [Description("Kansas")]
        KS,
        [Description("Kentucky")]
        KY,
        [Description("Louisiana")]
        LA,
        [Description("Maine")]
        ME,
        [Description("Maryland")]
        MD,
        [Description("Massachusetts")]
        MA,
        [Description("Michigan")]
        MI,
        [Description("Minnesota")]
        MN,
        [Description("Mississippi")]
        MS,
        [Description("Missouri")]
        MO,
        [Description("Montana")]
        MT,
        [Description("Nebraska")]
        NE,
        [Description("Nevada")]
        NV,
        [Description("New Hampshire")]
        NH,
        [Description("New Jersey")]
        NJ,
        [Description("New Mexico")]
        NM,
        [Description("New York")]
        NY,
        [Description("North Carolina")]
        NC,
        [Description("North Dakota")]
        ND,
        [Description("Ohio")]
        OH,
        [Description("Oklahoma")]
        OK,
        [Description("Oregon")]
        OR,
        [Description("Pennsylvania")]
        PA,
        [Description("Rhode Island")]
        RI,
        [Description("South Carolina")]
        SC,
        [Description("South Dakota")]
        SD,
        [Description("Tennessee")]
        TN,
        [Description("Texas")]
        TX,
        [Description("Utah")]
        UT,
        [Description("Vermont")]
        VT,
        [Description("Virginia ")]
        VA,
        [Description("Washington")]
        WA,
        [Description("West Virginia")]
        WV,
        [Description("Wisconsin")]
        WI,
        [Description("Wyoming")]
        WY,
    }
}
