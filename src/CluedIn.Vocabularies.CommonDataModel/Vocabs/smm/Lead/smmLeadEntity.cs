using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmLeadEntityVocabulary : SimpleVocabulary
    {
        public SmmLeadEntityVocabulary()
        {
            VocabularyName = "Smm Lead Entity";
            KeyPrefix = "commonDataModel.smmleadentity";
            KeySeparator = ".";
            Grouping = "/SmmLeadEntity";

            AddGroup("SmmLeadEntity Details", group =>
            {
                LeadId = group.Add(new VocabularyKey(nameof(LeadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Memo = group.Add(new VocabularyKey(nameof(Memo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(LeadResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadPartyNumber = group.Add(new VocabularyKey(nameof(LeadPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadPriorityCode = group.Add(new VocabularyKey(nameof(LeadPriorityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadQualifyingProcessName = group.Add(new VocabularyKey(nameof(LeadQualifyingProcessName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadRatingId = group.Add(new VocabularyKey(nameof(LeadRatingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadClosingPersonnelNumber = group.Add(new VocabularyKey(nameof(LeadClosingPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadClosedDate = group.Add(new VocabularyKey(nameof(LeadClosedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadOpeningPersonnelNumber = group.Add(new VocabularyKey(nameof(LeadOpeningPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadOpenedDate = group.Add(new VocabularyKey(nameof(LeadOpenedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadClosedOpportunityReasonCode = group.Add(new VocabularyKey(nameof(LeadClosedOpportunityReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitId = group.Add(new VocabularyKey(nameof(SalesUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadStatus = group.Add(new VocabularyKey(nameof(LeadStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Subject = group.Add(new VocabularyKey(nameof(Subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadTypeId = group.Add(new VocabularyKey(nameof(LeadTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceRefRecId = group.Add(new VocabularyKey(nameof(SourceRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceRefTableId = group.Add(new VocabularyKey(nameof(SourceRefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadSourceTypeId = group.Add(new VocabularyKey(nameof(LeadSourceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceActivityNumber = group.Add(new VocabularyKey(nameof(SourceActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCampaignId = group.Add(new VocabularyKey(nameof(SourceCampaignId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(SourceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProspectId = group.Add(new VocabularyKey(nameof(SourceProspectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceVendorAccountNumber = group.Add(new VocabularyKey(nameof(SourceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(SourceWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserDefinedSourceId = group.Add(new VocabularyKey(nameof(UserDefinedSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey Memo { get; private set; }
        public VocabularyKey LeadResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey LeadPartyNumber { get; private set; }
        public VocabularyKey LeadPriorityCode { get; private set; }
        public VocabularyKey LeadQualifyingProcessName { get; private set; }
        public VocabularyKey LeadRatingId { get; private set; }
        public VocabularyKey LeadClosingPersonnelNumber { get; private set; }
        public VocabularyKey LeadClosedDate { get; private set; }
        public VocabularyKey LeadOpeningPersonnelNumber { get; private set; }
        public VocabularyKey LeadOpenedDate { get; private set; }
        public VocabularyKey LeadClosedOpportunityReasonCode { get; private set; }
        public VocabularyKey SalesUnitId { get; private set; }
        public VocabularyKey LeadStatus { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey LeadTypeId { get; private set; }
        public VocabularyKey SourceRefRecId { get; private set; }
        public VocabularyKey SourceRefTableId { get; private set; }
        public VocabularyKey LeadSourceTypeId { get; private set; }
        public VocabularyKey SourceActivityNumber { get; private set; }
        public VocabularyKey SourceCampaignId { get; private set; }
        public VocabularyKey SourceCustomerAccountNumber { get; private set; }
        public VocabularyKey SourceProspectId { get; private set; }
        public VocabularyKey SourceVendorAccountNumber { get; private set; }
        public VocabularyKey SourceWorkerPersonnelNumber { get; private set; }
        public VocabularyKey UserDefinedSourceId { get; private set; }
    }
}