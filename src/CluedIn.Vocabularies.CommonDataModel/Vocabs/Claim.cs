using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ClaimVocabulary : SimpleVocabulary
    {
        public ClaimVocabulary()
        {
            VocabularyName = "Claim";
            KeyPrefix = "commonDataModel.claim";
            KeySeparator = ".";
            Grouping = "/Claim";

            AddGroup("Claim Details", group =>
            {
                BillablePeriodEnd = group.Add(new VocabularyKey(nameof(BillablePeriodEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillablePeriodStart = group.Add(new VocabularyKey(nameof(BillablePeriodStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClaimAccident = group.Add(new VocabularyKey(nameof(ClaimAccident), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClaimAccidentDate = group.Add(new VocabularyKey(nameof(ClaimAccidentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClaimId = group.Add(new VocabularyKey(nameof(ClaimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentImpactEnd = group.Add(new VocabularyKey(nameof(EmploymentImpactEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentImpactStart = group.Add(new VocabularyKey(nameof(EmploymentImpactStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundsReserve = group.Add(new VocabularyKey(nameof(FundsReserve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HospitalizationEnd = group.Add(new VocabularyKey(nameof(HospitalizationEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HospitalizationStart = group.Add(new VocabularyKey(nameof(HospitalizationStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayeeResourceType = group.Add(new VocabularyKey(nameof(PayeeResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedReference = group.Add(new VocabularyKey(nameof(RelatedReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedRelationship = group.Add(new VocabularyKey(nameof(RelatedRelationship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubType = group.Add(new VocabularyKey(nameof(SubType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Use = group.Add(new VocabularyKey(nameof(Use), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BillablePeriodEnd { get; private set; }
        public VocabularyKey BillablePeriodStart { get; private set; }
        public VocabularyKey ClaimAccident { get; private set; }
        public VocabularyKey ClaimAccidentDate { get; private set; }
        public VocabularyKey ClaimId { get; private set; }
        public VocabularyKey EmploymentImpactEnd { get; private set; }
        public VocabularyKey EmploymentImpactStart { get; private set; }
        public VocabularyKey FundsReserve { get; private set; }
        public VocabularyKey HospitalizationEnd { get; private set; }
        public VocabularyKey HospitalizationStart { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PayeeResourceType { get; private set; }
        public VocabularyKey RelatedReference { get; private set; }
        public VocabularyKey RelatedRelationship { get; private set; }
        public VocabularyKey SubType { get; private set; }
        public VocabularyKey Use { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}