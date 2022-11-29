using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class FaxVocabulary : SimpleVocabulary
    {
        public FaxVocabulary()
        {
            VocabularyName = "Fax";
            KeyPrefix = "commonDataModel.fax.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Fax";

            AddGroup("Fax Details for ApplicationCommon", group =>
            {
			    CoverPageName = group.Add(new VocabularyKey(nameof(CoverPageName), "Cover Page Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), "Billing Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Activity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfPages = group.Add(new VocabularyKey(nameof(NumberOfPages), "Number of Pages", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FaxNumber = group.Add(new VocabularyKey(nameof(FaxNumber), "Fax Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Tsid = group.Add(new VocabularyKey(nameof(Tsid), "Transmit. Station Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsBilled = group.Add(new VocabularyKey(nameof(IsBilled), "Is Billed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CoverPageName { get; private set; }
        public VocabularyKey BillingCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey NumberOfPages { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FaxNumber { get; private set; }
        public VocabularyKey Tsid { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey IsBilled { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
    }
}