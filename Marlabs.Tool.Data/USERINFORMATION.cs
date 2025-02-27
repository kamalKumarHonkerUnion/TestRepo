
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Marlabs.Tool.Data
{

using System;
    using System.Collections.Generic;
    
public partial class USERINFORMATION
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public USERINFORMATION()
    {

        this.MEDICALINFOes = new HashSet<MEDICALINFO>();

    }


    public int USERINFORMATIONID { get; set; }

    public int USERID { get; set; }

    public string USERFIRSTNAME { get; set; }

    public string USERMIDLEINITIAL { get; set; }

    public string USERLASTNAME { get; set; }

    public Nullable<int> AGE { get; set; }

    public string GENDER { get; set; }

    public string PRIMARYCONTACTNO { get; set; }

    public string ALTERNATECONTACTNO { get; set; }

    public string ADDRESS { get; set; }

    public string CITY { get; set; }

    public string STATE { get; set; }

    public string ZIP { get; set; }

    public string LATITUDE { get; set; }

    public string LONGITUDE { get; set; }

    public Nullable<System.DateTime> CREATEDON { get; set; }

    public Nullable<System.DateTime> UPDATEDON { get; set; }

    public string TREATMENTTYPE { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MEDICALINFO> MEDICALINFOes { get; set; }

    public virtual USERLOGIN USERLOGIN { get; set; }

}

}
