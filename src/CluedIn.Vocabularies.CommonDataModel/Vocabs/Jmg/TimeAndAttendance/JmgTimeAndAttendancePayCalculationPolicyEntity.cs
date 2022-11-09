using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendancePayCalculationPolicyEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendancePayCalculationPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgTimeAndAttendancePayCalculationPolicyEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendancepaycalculationpolicyentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendancePayCalculationPolicyEntity";

            AddGroup("Common Data Model JmgTimeAndAttendancePayCalculationPolicyEntity Details", group =>
            {
                ProfileSpecificationTypeCode = group.Add(new VocabularyKey(nameof(ProfileSpecificationTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegistrationSpecificationType = group.Add(new VocabularyKey(nameof(RegistrationSpecificationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIllegalAbsenceIncludedInCalculation = group.Add(new VocabularyKey(nameof(IsIllegalAbsenceIncludedInCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLegalAbsenceIncludedInCalculation = group.Add(new VocabularyKey(nameof(IsLegalAbsenceIncludedInCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFlexPlusIncludedInCalculation = group.Add(new VocabularyKey(nameof(IsFlexPlusIncludedInCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFlexMinusIncludedInCalculation = group.Add(new VocabularyKey(nameof(IsFlexMinusIncludedInCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOverTimeIncludedInCalculation = group.Add(new VocabularyKey(nameof(IsOverTimeIncludedInCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPayTimeIncludedInCalculation = group.Add(new VocabularyKey(nameof(IsPayTimeIncludedInCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsStandardTimeIncludedInCalculation = group.Add(new VocabularyKey(nameof(IsStandardTimeIncludedInCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAbsenceIncludedInPay = group.Add(new VocabularyKey(nameof(IsAbsenceIncludedInPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPremiumIncludedInPay = group.Add(new VocabularyKey(nameof(IsPremiumIncludedInPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBreakIncludedInPay = group.Add(new VocabularyKey(nameof(IsBreakIncludedInPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFlexPlusIncludedInPay = group.Add(new VocabularyKey(nameof(IsFlexPlusIncludedInPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFlexMinusIncludedInPay = group.Add(new VocabularyKey(nameof(IsFlexMinusIncludedInPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOverTimeIncludedInPay = group.Add(new VocabularyKey(nameof(IsOverTimeIncludedInPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPayTimeIncludedInPay = group.Add(new VocabularyKey(nameof(IsPayTimeIncludedInPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProfileSpecificationTypeCode { get; private set; }
public VocabularyKey RegistrationSpecificationType { get; private set; }
public VocabularyKey IsIllegalAbsenceIncludedInCalculation { get; private set; }
public VocabularyKey IsLegalAbsenceIncludedInCalculation { get; private set; }
public VocabularyKey IsFlexPlusIncludedInCalculation { get; private set; }
public VocabularyKey IsFlexMinusIncludedInCalculation { get; private set; }
public VocabularyKey IsOverTimeIncludedInCalculation { get; private set; }
public VocabularyKey IsPayTimeIncludedInCalculation { get; private set; }
public VocabularyKey IsStandardTimeIncludedInCalculation { get; private set; }
public VocabularyKey IsAbsenceIncludedInPay { get; private set; }
public VocabularyKey IsPremiumIncludedInPay { get; private set; }
public VocabularyKey IsBreakIncludedInPay { get; private set; }
public VocabularyKey IsFlexPlusIncludedInPay { get; private set; }
public VocabularyKey IsFlexMinusIncludedInPay { get; private set; }
public VocabularyKey IsOverTimeIncludedInPay { get; private set; }
public VocabularyKey IsPayTimeIncludedInPay { get; private set; }


    }
}