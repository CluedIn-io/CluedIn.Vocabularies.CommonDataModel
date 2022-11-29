using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class WarrantyLimitVocabulary : SimpleVocabulary
    {
        public WarrantyLimitVocabulary()
        {
            VocabularyName = "Warranty Limit";
            KeyPrefix = "commonDataModel.warrantylimit.automotive";
            KeySeparator = ".";
            Grouping = "/WarrantyLimit";

            AddGroup("WarrantyLimit Details for Automotive", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    WarrantyLimitId = group.Add(new VocabularyKey(nameof(WarrantyLimitId), "Warranty Limit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey WarrantyLimitId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}