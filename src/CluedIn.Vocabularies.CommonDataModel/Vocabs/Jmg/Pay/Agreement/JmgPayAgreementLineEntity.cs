using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgPayAgreementLineEntityVocabulary : SimpleVocabulary
    {
        public JmgPayAgreementLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgPayAgreementLineEntity";
            KeyPrefix = "commonDataModel.jmgpayagreementlineentity";
            KeySeparator = ".";
            Grouping = "/JmgPayAgreementLineEntity";

            AddGroup("Common Data Model JmgPayAgreementLineEntity Details", group =>
            {
                AbsenceIndirectTimeAndAttendanceActivityId = group.Add(new VocabularyKey(nameof(AbsenceIndirectTimeAndAttendanceActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCancelPayment = group.Add(new VocabularyKey(nameof(WillCancelPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequiredCertificateType = group.Add(new VocabularyKey(nameof(RequiredCertificateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SwitchCodeIndirectTimeAndAttendanceActivityId = group.Add(new VocabularyKey(nameof(SwitchCodeIndirectTimeAndAttendanceActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryPayQuantityFactor = group.Add(new VocabularyKey(nameof(PrimaryPayQuantityFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromAgreementDate = group.Add(new VocabularyKey(nameof(FromAgreementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AbsenceCode = group.Add(new VocabularyKey(nameof(AbsenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobPayRateMethod = group.Add(new VocabularyKey(nameof(JobPayRateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumSeniorityUnit = group.Add(new VocabularyKey(nameof(MaximumSeniorityUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OnCallIndirectTimeAndAttendanceActivityId = group.Add(new VocabularyKey(nameof(OnCallIndirectTimeAndAttendanceActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayAgreementCode = group.Add(new VocabularyKey(nameof(PayAgreementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConstantPayQuantity = group.Add(new VocabularyKey(nameof(ConstantPayQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryPayTypeCode = group.Add(new VocabularyKey(nameof(PrimaryPayTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayAgreementCountUnitId = group.Add(new VocabularyKey(nameof(PayAgreementCountUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WageType = group.Add(new VocabularyKey(nameof(WageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TimeProfileId = group.Add(new VocabularyKey(nameof(TimeProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfileStartCode = group.Add(new VocabularyKey(nameof(ProfileStartCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundOffSeconds = group.Add(new VocabularyKey(nameof(RoundOffSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillRoundOffQuantityBeforeMultiplyingFactor = group.Add(new VocabularyKey(nameof(WillRoundOffQuantityBeforeMultiplyingFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayQuantityRoundingType = group.Add(new VocabularyKey(nameof(PayQuantityRoundingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteOperationId = group.Add(new VocabularyKey(nameof(RouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecondaryPayQuantityFactor = group.Add(new VocabularyKey(nameof(SecondaryPayQuantityFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecondaryPayTypeCode = group.Add(new VocabularyKey(nameof(SecondaryPayTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumSeniorityUnit = group.Add(new VocabularyKey(nameof(MinimumSeniorityUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumSeniority = group.Add(new VocabularyKey(nameof(MaximumSeniority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumSeniority = group.Add(new VocabularyKey(nameof(MinimumSeniority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequiredSkillId = group.Add(new VocabularyKey(nameof(RequiredSkillId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayAgreementExceptionId = group.Add(new VocabularyKey(nameof(PayAgreementExceptionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromAgreementTime = group.Add(new VocabularyKey(nameof(FromAgreementTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInvertedSign = group.Add(new VocabularyKey(nameof(IsInvertedSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToAgreementTime = group.Add(new VocabularyKey(nameof(ToAgreementTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToAgreementDate = group.Add(new VocabularyKey(nameof(ToAgreementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPayQuantityFixed = group.Add(new VocabularyKey(nameof(IsPayQuantityFixed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPaidTimeRequired = group.Add(new VocabularyKey(nameof(IsPaidTimeRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AbsenceIndirectTimeAndAttendanceActivityId { get; private set; }
public VocabularyKey ProjectActivityNumber { get; private set; }
public VocabularyKey WillCancelPayment { get; private set; }
public VocabularyKey RequiredCertificateType { get; private set; }
public VocabularyKey SwitchCodeIndirectTimeAndAttendanceActivityId { get; private set; }
public VocabularyKey PrimaryPayQuantityFactor { get; private set; }
public VocabularyKey FromAgreementDate { get; private set; }
public VocabularyKey AbsenceCode { get; private set; }
public VocabularyKey JobPayRateMethod { get; private set; }
public VocabularyKey MaximumSeniorityUnit { get; private set; }
public VocabularyKey OnCallIndirectTimeAndAttendanceActivityId { get; private set; }
public VocabularyKey PayAgreementCode { get; private set; }
public VocabularyKey ConstantPayQuantity { get; private set; }
public VocabularyKey PrimaryPayTypeCode { get; private set; }
public VocabularyKey PayAgreementCountUnitId { get; private set; }
public VocabularyKey WageType { get; private set; }
public VocabularyKey TimeProfileId { get; private set; }
public VocabularyKey ProfileStartCode { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey RoundOffSeconds { get; private set; }
public VocabularyKey WillRoundOffQuantityBeforeMultiplyingFactor { get; private set; }
public VocabularyKey PayQuantityRoundingType { get; private set; }
public VocabularyKey RouteOperationId { get; private set; }
public VocabularyKey SecondaryPayQuantityFactor { get; private set; }
public VocabularyKey SecondaryPayTypeCode { get; private set; }
public VocabularyKey MinimumSeniorityUnit { get; private set; }
public VocabularyKey MaximumSeniority { get; private set; }
public VocabularyKey MinimumSeniority { get; private set; }
public VocabularyKey RequiredSkillId { get; private set; }
public VocabularyKey PayAgreementExceptionId { get; private set; }
public VocabularyKey FromAgreementTime { get; private set; }
public VocabularyKey RecordId { get; private set; }
public VocabularyKey IsInvertedSign { get; private set; }
public VocabularyKey ToAgreementTime { get; private set; }
public VocabularyKey ToAgreementDate { get; private set; }
public VocabularyKey IsPayQuantityFixed { get; private set; }
public VocabularyKey IsPaidTimeRequired { get; private set; }


    }
}