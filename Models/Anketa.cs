using EcoTaxiAPI.Models.Abstrat;

namespace EcoTaxiAPI.Models
{
    public class Anketa: DbRecord
    {
        public string full_name { get; set; }
        public string birth_date_place { get; set; }
        public string registration_address { get; set; }
        public string residential_address { get; set; }
        public string mobile_phone { get; set; }
        public string home_phone { get; set; }
        public string passport_serial_number { get; set; }
        public string passport_issued_by { get; set; }
        public string passport_issued_date { get; set; }
        public string email { get; set; }
        public bool source_radio { get; set; }
        public bool source_tv { get; set; }
        public bool source_newspaper { get; set; }
        public bool source_website { get; set; }
        public bool source_job_center { get; set; }
        public string marital_status { get; set; }
        public string children_info { get; set; }
        public string children_birthday { get; set; }
        public string father_birthday { get; set; }
        public string father_place_of_work_position { get; set; }
        public string father_phone_number { get; set; }
        public string mother_birthday { get; set; }
        public string mother_place_of_work_position { get; set; }
        public string mother_phone_number { get; set; }
        public string spouce_birthday { get; set; }
        public string spouce_place_of_work_position { get; set; }
        public string spouce_phone_number { get; set; }
        public bool education_higher { get; set; }
        public bool education_higher_incomplete { get; set; }
        public bool education_secondary_technical { get; set; }
        public string university { get; set; }
        public string study_years { get; set; }
        public string specialty { get; set; }
        public string computer_skills { get; set; }
        public string language_1 { get; set; }
        public string language_level_1 { get; set; }
        public string language_2 { get; set; }
        public string language_level_2 { get; set; }
        public string language_3 { get; set; }
        public string language_level_3 { get; set; }
        public string work_experience { get; set; }
        public string last_workplace { get; set; }
        public string work_start_date { get; set; }
        public string position { get; set; }
        public string reason_for_leaving { get; set; }
        public string workplace_1 { get; set; }
        public string position_1 { get; set; }
        public string driver_years_1 { get; set; }
        public string workplace_2 { get; set; }
        public string position_2 { get; set; }
        public string driver_years_2 { get; set; }
        public string workplace_3 { get; set; }
        public string position_3 { get; set; }
        public string driver_years_3 { get; set; }
        public string workplace_4 { get; set; }
        public string position_4 { get; set; }
        public string driver_years_4 { get; set; }
        public string referee { get; set; }
        public string referee_phone { get; set; }
        public string military_ticket { get; set; }
        public string criminal_record { get; set; }
        public string acquaintances { get; set; }
        public string expected_salary { get; set; }
        public bool probation_agreement { get; set; }
        public string can_start_work_date { get; set; }
        public bool additional_info_consent { get; set; }
    }
}

