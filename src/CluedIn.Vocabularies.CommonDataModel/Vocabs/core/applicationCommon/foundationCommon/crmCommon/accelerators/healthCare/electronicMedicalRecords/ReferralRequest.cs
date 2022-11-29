using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ReferralRequestVocabulary : SimpleVocabulary
    {
        public ReferralRequestVocabulary()
        {
            VocabularyName = "Referral Request";
            KeyPrefix = "commonDataModel.referralrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ReferralRequest";

            AddGroup("ReferralRequest Details for ElectronicMedicalRecords", group =>
            {
			    AuthoredOn = group.Add(new VocabularyKey(nameof(AuthoredOn), "Authored On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Referral Request Context", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GroupIdentifier = group.Add(new VocabularyKey(nameof(GroupIdentifier), "Group Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Intent = group.Add(new VocabularyKey(nameof(Intent), "Referral Request Intent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurencePeriodEndDate = group.Add(new VocabularyKey(nameof(OccurencePeriodEndDate), "Occurrence End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurencePeriodStartDate = group.Add(new VocabularyKey(nameof(OccurencePeriodStartDate), "Occurrence Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceDate = group.Add(new VocabularyKey(nameof(OccurrenceDate), "Occurrence Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceType = group.Add(new VocabularyKey(nameof(OccurrenceType), "Occurrence Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Referral Request Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestId = group.Add(new VocabularyKey(nameof(ReferralRequestId), "Referral Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferralRequestNumber = group.Add(new VocabularyKey(nameof(ReferralRequestNumber), "Referral Request Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequesterAgent = group.Add(new VocabularyKey(nameof(RequesterAgent), "Requester Agent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Referral Request Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Referral Request Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Referral Request Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AuthoredOn { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey GroupIdentifier { get; private set; }
        public VocabularyKey Intent { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OccurencePeriodEndDate { get; private set; }
        public VocabularyKey OccurencePeriodStartDate { get; private set; }
        public VocabularyKey OccurrenceDate { get; private set; }
        public VocabularyKey OccurrenceType { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey ReferralRequestId { get; private set; }
        public VocabularyKey ReferralRequestNumber { get; private set; }
        public VocabularyKey RequesterAgent { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}