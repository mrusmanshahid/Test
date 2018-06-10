﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class login
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public login()
    {
        this.Questionnares = new HashSet<Questionnare>();
        this.Sleepdiaries = new HashSet<Sleepdiary>();
    }

    public int LoginID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Type { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Questionnare> Questionnares { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Sleepdiary> Sleepdiaries { get; set; }
}

public partial class Questionnare
{
    public int Qid { get; set; }
    public Nullable<int> Login_id { get; set; }
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    public string Lastname { get; set; }
    public Nullable<int> Weight { get; set; }
    public Nullable<int> height_feet { get; set; }
    public Nullable<int> height_inches { get; set; }
    public Nullable<int> Age { get; set; }
    public string Gender { get; set; }
    public string DateofBirth { get; set; }
    public string HighBloodPressure { get; set; }
    public string RestLessSyndrome { get; set; }
    public string Narcolepsy { get; set; }
    public string HeartDisease { get; set; }
    public string SleepApnea { get; set; }
    public string Depression { get; set; }
    public string Stroke { get; set; }
    public string AMHeadaches { get; set; }
    public string Diabetes { get; set; }
    public string Insomnia { get; set; }
    public Nullable<int> SittingandReading { get; set; }
    public Nullable<int> WatchingTV { get; set; }
    public Nullable<int> Sittinginactive { get; set; }
    public Nullable<int> AsPassenger { get; set; }
    public Nullable<int> LyingDown { get; set; }
    public Nullable<int> SittingTalking { get; set; }
    public Nullable<int> SittingQuietly { get; set; }
    public Nullable<int> InCar { get; set; }
    public string DifficultyFallingaseelp { get; set; }
    public string DifficultyStayingaseelp { get; set; }
    public string ProblemWaking { get; set; }
    public string SleepProblem { get; set; }
    public string DrinkAlcohol { get; set; }
    public string Beverages { get; set; }
    public string LegsAtNight { get; set; }
    public string Vivid { get; set; }
    public string Snored { get; set; }
    public string Choking { get; set; }
    public string StopBreathing { get; set; }
    public string Medication { get; set; }
    public string OvertheCounter { get; set; }
    public string Ambien { get; set; }
    public string Rozerem { get; set; }
    public string Intermezzo { get; set; }
    public string NarcoticForPain { get; set; }
    public string HeartMedication { get; set; }
    public string Antihistamines { get; set; }
    public string Lunesta { get; set; }
    public string Sonata { get; set; }
    public string Silenor { get; set; }
    public string BloodMedication { get; set; }
    public string AntiDepressant { get; set; }
    public string Anitanxiety { get; set; }
    public string Halcion { get; set; }
    public string Restoril { get; set; }
    public string Xanax { get; set; }
    public string Steroid { get; set; }
    public string Parkinson { get; set; }
    public string Simulant { get; set; }

    public virtual login login { get; set; }
}

public partial class Sleepdiary
{
    public int Diary_id { get; set; }
    public int Login_id { get; set; }
    public Nullable<int> Night { get; set; }
    public System.DateTime DateStart { get; set; }
    public string Prescription { get; set; }
    public string beverages { get; set; }
    public string caffeinated { get; set; }
    public Nullable<System.TimeSpan> lights { get; set; }
    public Nullable<int> sleephours { get; set; }
    public Nullable<int> sleepminutes { get; set; }
    public string wokeup { get; set; }
    public string totaltime { get; set; }
    public Nullable<System.TimeSpan> turnofftime { get; set; }
    public Nullable<int> totalsleephours { get; set; }
    public Nullable<int> totalsleepmin { get; set; }

    public virtual login login { get; set; }
}
