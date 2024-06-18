
using EcoTaxiAPI.Models;

namespace EcoTaxiAPI.Services.Implementation.Helpers
{
    public static class PlaceHolderMapping
    {
        public static Dictionary<string, string> GetMappings(Anketa anketaDTO)
        {
            return new Dictionary<string, string>
            {
                { "{FullName}", anketaDTO.full_name?? string.Empty },
                { "{BirthDatePlace}", anketaDTO.birth_date_place ?? string.Empty },
                { "{RegistrationAddress}", anketaDTO.registration_address ?? string.Empty },
                { "{ResidentialAddress}", anketaDTO.residential_address ?? string.Empty },
                { "{MobilePhone}", anketaDTO.mobile_phone?? string.Empty },
                { "{HomePhone}", anketaDTO.home_phone ?? string.Empty },
                { "{PassportSerialNumber}", anketaDTO.passport_serial_number?? string.Empty },
                { "{PassportIssuedBy}", anketaDTO.passport_issued_by?? string.Empty },
                { "{PassportIssuedDate}", anketaDTO.passport_issue_date ?? string.Empty},
                { "{Email}", anketaDTO.email ?? string.Empty },
                { "{SourceRadio}", anketaDTO.source_radio?.ToLower() == "radio" ? "хо" : ""},
                { "{SourceTV}", anketaDTO.source_tv?.ToLower() == "tv" ? "хо" : "" },
                { "{SourceNewspaper}", anketaDTO.source_newspaper ?.ToLower() == "newspaper" ? "хо" : "" },
                { "{SourceWebsite}", anketaDTO.source_website ?.ToLower() == "website" ? "хо" : "" },
                { "{SourceJobCenter}", anketaDTO.source_job_center ?.ToLower() == "job_center" ? "хо" : "" },
                { "{MaritalStatus}", anketaDTO.marital_status ?? string.Empty },
                { "{ChildrenInfo}", anketaDTO.children_info ?? string.Empty },
                { "{ChildrenBirthday}", anketaDTO.children_birthday ?? string.Empty },
                { "{FatherBirthday}", anketaDTO.father_birthday?? string.Empty },
                { "{FatherWorkPosition}", anketaDTO.father_place_of_work_position ?? string.Empty },
                { "{FatherPhoneNumber}", anketaDTO.father_phone_number ?? string.Empty},
                { "{MotherBirthday}", anketaDTO.mother_birthday ?? string.Empty },
                { "{MotherWorkPosition}", anketaDTO.mother_place_of_work_position ?? string.Empty },
                { "{MotherPhoneNumber}", anketaDTO.mother_phone_number ?? string.Empty},
                { "{SpouceBirthday}", anketaDTO.spouse_birthday ?? string.Empty},
                { "{SpouceWorkPosition}", anketaDTO.spouse_place_of_work_position ?? string.Empty},
                { "{SpoucePhoneNumber}", anketaDTO.spouse_phone_number ?? string.Empty},
                {"{Education}",
                    ((anketaDTO.education_higher?.ToLower() == "higher" ? "оли" : "") +
                     (anketaDTO.education_higher_incomplete?.ToLower() == "higher_incomplete" ?
                       (anketaDTO.education_higher?.ToLower() == "higher" ? ", олӣ нопура" : "олӣ нопура") : "") +
                        (anketaDTO.education_secondary_technical?.ToLower() == "secondary_technical" ?
                          ((anketaDTO.education_higher?.ToLower() == "higher" ||
                            anketaDTO.education_higher_incomplete?.ToLower() == "higher_incomplete") ?
                          ", миёнаи техники" : "миёнаи техники") : ""))},
                { "{University}", anketaDTO.university ?? string.Empty},   
                { "{StudyYears}", anketaDTO.study_years ?? string.Empty},
                { "{Speciality}", anketaDTO.specialty ?? string.Empty},
                { "{ComputerSkills}", anketaDTO.computer_skills ?? string.Empty},
                { "{Language1}", anketaDTO.language_1 ?? string.Empty},
                { "{LanguageLevel1}", anketaDTO.language_level_1 ?? string.Empty},
                { "{Language2}", anketaDTO.language_2 ?? string.Empty},
                { "{LanguageLevel2}", anketaDTO.language_level_2 ?? string.Empty},
                { "{Language3}", anketaDTO.language_3 ?? string.Empty},
                { "{LanguageLevel3}", anketaDTO.language_level_3 ?? string.Empty},
                { "{WorkExperience}", anketaDTO.work_experience ?? string.Empty },
                { "{LastWorkPlace}", anketaDTO.last_workplace ?? string.Empty},
                { "{WorkStartDate}", anketaDTO.work_start_date ?? string.Empty},
                { "{Position}", anketaDTO.position ?? string.Empty},
                { "{ReasonForLeaving}", anketaDTO.reason_for_leaving ?? string.Empty },
                { "{WorkPlace1}", anketaDTO.workplace_1 ?? string.Empty},
                { "{Position1}", anketaDTO.position_1 ?? string.Empty},
                { "{DriverYears1}", anketaDTO.driver_years_1 ?? string.Empty},
                { "{WorkPlace2}", anketaDTO.workplace_2 ?? string.Empty},
                { "{Position2}", anketaDTO.position_2 ?? string.Empty},
                { "{DriverYears2}", anketaDTO.driver_years_2 ?? string.Empty},
                { "{WorkPlace3}", anketaDTO.workplace_3 ?? string.Empty},
                { "{Position3}", anketaDTO.position_3 ?? string.Empty},
                { "{DriverYears3}", anketaDTO.driver_years_3 ?? string.Empty},
                { "{WorkPlace4}", anketaDTO.workplace_4 ?? string.Empty},
                { "{Position4}", anketaDTO.position_4 ?? string.Empty},
                { "{DriverYears4}", anketaDTO.driver_years_4 ?? string.Empty},
                { "{Referee}", anketaDTO.referee ?? string.Empty},
                { "{RefereePhoneNumber}", anketaDTO.referee_phone ?? string.Empty},
                { "{MilitaryTicket}", anketaDTO.military_ticket ?? string.Empty},
                { "{CriminalRecord}", anketaDTO.criminal_record ?? string.Empty},
                { "{Acquintances}", anketaDTO.acquaintances ?? string.Empty},
                { "{expectedSalary}", anketaDTO.expected_salary?? string.Empty},
                { "{ProbationAgreemnet}", anketaDTO.probation_agreement?.ToLower() == "yes" ? "Бале" : "Рози нестам" },
                { "{canStartWorkDate}", anketaDTO.can_start_work_date ?? string.Empty },
                { "{AdditionalInfoConsent}", anketaDTO.additional_info_consent?.ToLower() == "yes" ? "Бале" : "Рози Нестам" }
            };
        }
    }
}
