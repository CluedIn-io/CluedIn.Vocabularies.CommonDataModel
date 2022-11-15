using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjGrantEntityVocabulary : SimpleVocabulary
    {
        public ProjGrantEntityVocabulary()
        {
            VocabularyName = "Proj Grant Entity";
            KeyPrefix = "commonDataModel.projgrantentity";
            KeySeparator = ".";
            Grouping = "/ProjGrantEntity";

            AddGroup("ProjGrantEntity Details", group =>
            {
                ActualAwardDate = group.Add(new VocabularyKey(nameof(ActualAwardDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualExpirationDate = group.Add(new VocabularyKey(nameof(ActualExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualStartDate = group.Add(new VocabularyKey(nameof(ActualStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicationDueDate = group.Add(new VocabularyKey(nameof(ApplicationDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicationSubmittedDate = group.Add(new VocabularyKey(nameof(ApplicationSubmittedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AwardedAmount = group.Add(new VocabularyKey(nameof(AwardedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BoardApprovalDate = group.Add(new VocabularyKey(nameof(BoardApprovalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFDAId = group.Add(new VocabularyKey(nameof(CFDAId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedAwardDate = group.Add(new VocabularyKey(nameof(EstimatedAwardDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FederalMandate = group.Add(new VocabularyKey(nameof(FederalMandate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantApplicationId = group.Add(new VocabularyKey(nameof(GrantApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantDescription = group.Add(new VocabularyKey(nameof(GrantDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantId = group.Add(new VocabularyKey(nameof(GrantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantManagerWorker = group.Add(new VocabularyKey(nameof(GrantManagerWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantMatchingComments = group.Add(new VocabularyKey(nameof(GrantMatchingComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantName = group.Add(new VocabularyKey(nameof(GrantName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantParentId = group.Add(new VocabularyKey(nameof(GrantParentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantPurpose = group.Add(new VocabularyKey(nameof(GrantPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantStatus = group.Add(new VocabularyKey(nameof(GrantStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingAmount = group.Add(new VocabularyKey(nameof(MatchingAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingPercentage = group.Add(new VocabularyKey(nameof(MatchingPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitId = group.Add(new VocabularyKey(nameof(OrganizationUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassThrough = group.Add(new VocabularyKey(nameof(PassThrough), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantMatching = group.Add(new VocabularyKey(nameof(ProjGrantMatching), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantorType = group.Add(new VocabularyKey(nameof(ProjGrantorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantType = group.Add(new VocabularyKey(nameof(ProjGrantType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjLocalTrackingId = group.Add(new VocabularyKey(nameof(ProjLocalTrackingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RejectionNotification = group.Add(new VocabularyKey(nameof(RejectionNotification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RenewalActionDate = group.Add(new VocabularyKey(nameof(RenewalActionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedAmount = group.Add(new VocabularyKey(nameof(RequestedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateMandate = group.Add(new VocabularyKey(nameof(StateMandate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubGrantor = group.Add(new VocabularyKey(nameof(SubGrantor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerContact = group.Add(new VocabularyKey(nameof(WorkerContact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantManagerWorker_PersonnelNumber = group.Add(new VocabularyKey(nameof(GrantManagerWorker_PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantMatching_MatchingTypeCode = group.Add(new VocabularyKey(nameof(ProjGrantMatching_MatchingTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantorType_GrantorType = group.Add(new VocabularyKey(nameof(ProjGrantorType_GrantorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantType_GrantType = group.Add(new VocabularyKey(nameof(ProjGrantType_GrantType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerContact_PersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerContact_PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActualAwardDate { get; private set; }
        public VocabularyKey ActualExpirationDate { get; private set; }
        public VocabularyKey ActualStartDate { get; private set; }
        public VocabularyKey ApplicationDueDate { get; private set; }
        public VocabularyKey ApplicationSubmittedDate { get; private set; }
        public VocabularyKey AwardedAmount { get; private set; }
        public VocabularyKey BoardApprovalDate { get; private set; }
        public VocabularyKey CFDAId { get; private set; }
        public VocabularyKey CustAccount { get; private set; }
        public VocabularyKey EstimatedAwardDate { get; private set; }
        public VocabularyKey FederalMandate { get; private set; }
        public VocabularyKey GrantApplicationId { get; private set; }
        public VocabularyKey GrantDescription { get; private set; }
        public VocabularyKey GrantId { get; private set; }
        public VocabularyKey GrantManagerWorker { get; private set; }
        public VocabularyKey GrantMatchingComments { get; private set; }
        public VocabularyKey GrantName { get; private set; }
        public VocabularyKey GrantParentId { get; private set; }
        public VocabularyKey GrantPurpose { get; private set; }
        public VocabularyKey GrantStatus { get; private set; }
        public VocabularyKey MatchingAmount { get; private set; }
        public VocabularyKey MatchingPercentage { get; private set; }
        public VocabularyKey OrganizationUnitId { get; private set; }
        public VocabularyKey PassThrough { get; private set; }
        public VocabularyKey ProjGrantMatching { get; private set; }
        public VocabularyKey ProjGrantorType { get; private set; }
        public VocabularyKey ProjGrantType { get; private set; }
        public VocabularyKey ProjLocalTrackingId { get; private set; }
        public VocabularyKey RejectionNotification { get; private set; }
        public VocabularyKey RenewalActionDate { get; private set; }
        public VocabularyKey RequestedAmount { get; private set; }
        public VocabularyKey StateMandate { get; private set; }
        public VocabularyKey SubGrantor { get; private set; }
        public VocabularyKey WorkerContact { get; private set; }
        public VocabularyKey GrantManagerWorker_PersonnelNumber { get; private set; }
        public VocabularyKey ProjGrantMatching_MatchingTypeCode { get; private set; }
        public VocabularyKey ProjGrantorType_GrantorType { get; private set; }
        public VocabularyKey ProjGrantType_GrantType { get; private set; }
        public VocabularyKey WorkerContact_PersonnelNumber { get; private set; }
    }
}