using EcoTaxiAPI.DTO;

namespace EcoTaxiAPI.Services.Implementation.Helpers
{
    public static class PlaceHolderMapping
    {
        public static Dictionary<string, string> GetMappings(AnketaDTO anketaDTO)
        {
            return new Dictionary<string, string>
            {
                { "{FullName}", anketaDTO.full_name },
                { "{BirthDatePlace}", anketaDTO.birth_date_place },
                { "{RegistrationAddress}", anketaDTO.registration_address },
                { "{ResidentialAddress}", anketaDTO.residential_address },
                { "{MobilePhone}", anketaDTO.mobile_phone },
                { "{HomePhone}", anketaDTO.home_phone },
                { "{PassportSerialNumber}", anketaDTO.passport_serial_number },
                { "{PassportIssuedBy}", anketaDTO.passport_issued_by },
                { "{PassportIssuedDate}", anketaDTO.passport_issue_date },
                { "{Email}", anketaDTO.email },
                { "{SourceRadio}", anketaDTO.source_radio.toLower() == "yes" ? "хо" : "не"},
                { "{SourceTV}", anketaDTO.source_tv.toLower() == "yes" ? "хо" : "не" },
                { "{SourceNewspaper}", anketaDTO.source_newspaper.toLower() == "yes" ? "хо" : "не" },
                { "{SourceWebsite}", anketaDTO.source_website.toLower() == "yes" ? "хо" : "не" },
                { "{SourceJobCenter}", anketaDTO.source_job_center.toLower() == "yes" ? "хо" : "не" },
                { "{MaritalStatus}", anketaDTO.marital_status },
                { "{ChildrenInfo}", anketaDTO.children_info },
                { "{ChildrenBirthday}", anketaDTO.children_birthday },
                { "{FatherBirthday}", anketaDTO.father_birthday },
                { "{FatherWorkPosition}", anketaDTO.father_place_of_work_position },
                { "{FatherPhoneNumber}", anketaDTO.father_phone_number },
                { "{MotherBirthday}", anketaDTO.mother_birthday },
                { "{MotherWorkPosition}", anketaDTO.mother_place_of_work_position },
                { "{MotherPhoneNumber}", anketaDTO.mother_phone_number },
                { "{SpouceBirthday}", anketaDTO.spouse_birthday },
                { "{SpouceWorkPosition}", anketaDTO.spouse_place_of_work_position },
                { "{SpoucePhoneNumber}", anketaDTO.spouse_phone_number },
                { "{Education}",
                anketaDTO.education_higher.toLower() == "yes" ? "оли" :
                anketaDTO.education_higher_incomplete.toLower() == "yes" ? "олии нопура" :
                anketaDTO.education_secondary_technical.toLower() == "yes" ? "миёнаи техники" : "" },
                { "{University}", anketaDTO.university },
                { "{StudyYears}", anketaDTO.study_years },
                { "{Speciality}", anketaDTO.specialty },
                { "{ComputerSkills}", anketaDTO.computer_skills },
                { "{Language1}", anketaDTO.language_1 },
                { "{LanguageLevel1}", anketaDTO.language_level_1 },
                { "{Language2}", anketaDTO.language_2 },
                { "{LanguageLevel2}", anketaDTO.language_level_2 },
                { "{Language3}", anketaDTO.language_3 },
                { "{LanguageLevel3}", anketaDTO.language_level_3 },
                { "{WorkExperience}", anketaDTO.work_experience },
                { "{LastWorkPlace}", anketaDTO.last_workplace },
                { "{WorkStartDate}", anketaDTO.work_start_date },
                { "{Position}", anketaDTO.position },
                { "{ReasonForLeaving}", anketaDTO.reason_for_leaving },
                { "{WorkPlace1}", anketaDTO.workplace_1 },
                { "{Position1}", anketaDTO.position_1 },
                { "{DriverYears1}", anketaDTO.driver_years_1 },
                { "{WorkPlace2}", anketaDTO.workplace_2 },
                { "{Position2}", anketaDTO.position_2 },
                { "{DriverYears2}", anketaDTO.driver_years_2 },
                { "{WorkPlace3}", anketaDTO.workplace_3 },
                { "{Position3}", anketaDTO.position_3 },
                { "{DriverYears3}", anketaDTO.driver_years_3 },
                { "{WorkPlace4}", anketaDTO.workplace_4 },
                { "{Position4}", anketaDTO.position_4 },
                { "{DriverYears4}", anketaDTO.driver_years_4 },
                { "{Referee}", anketaDTO.referee },
                { "{RefereePhoneNumber}", anketaDTO.referee_phone },
                { "{MilitaryTicket}", anketaDTO.military_ticket },
                { "{CriminalRecord}", anketaDTO.criminal_record },
                { "{Acquintances}", anketaDTO.acquaintances },
                { "{expectedSalary}", anketaDTO.expected_salary},
                { "{ProbationAgreemnet}", anketaDTO.probation_agreement.toLower() == "yes" ? "Бале" : "" },
                { "{canStartWorkDate}", anketaDTO.can_start_work_date },
                { "{AdditionalInfoConsent}", anketaDTO.additional_info_consent.toLower() == "yes" ? "Бале" : "" }
            };
        }
    }
}
