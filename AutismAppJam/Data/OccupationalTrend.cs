
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AutismAppJam.Data
{

using System;
    using System.Collections.Generic;
    
public partial class OccupationalTrend
{

    public string Occupation { get; set; }

    public string PersonalityType { get; set; }

    public string OccupationDescription { get; set; }

    public string OccupationImageURL { get; set; }



    public virtual Personality Personality { get; set; }

}

}
