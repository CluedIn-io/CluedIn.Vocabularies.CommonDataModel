using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class AidTypeVocabulary : SimpleVocabulary
    {
        public AidTypeVocabulary()
        {
            VocabularyName = "Aid Type";
            KeyPrefix = "commonDataModel.aidtype.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/AidType";

            AddGroup("AidType Details for NonProfitIati", group =>
            {
			    AidTypeId = group.Add(new VocabularyKey(nameof(AidTypeId), "Aid Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AidTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}