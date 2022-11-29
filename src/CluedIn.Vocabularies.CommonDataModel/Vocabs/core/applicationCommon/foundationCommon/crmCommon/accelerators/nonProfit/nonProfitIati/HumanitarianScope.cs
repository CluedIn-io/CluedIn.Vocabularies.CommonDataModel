using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class HumanitarianScopeVocabulary : SimpleVocabulary
    {
        public HumanitarianScopeVocabulary()
        {
            VocabularyName = "Humanitarian Scope";
            KeyPrefix = "commonDataModel.humanitarianscope.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/HumanitarianScope";

            AddGroup("HumanitarianScope Details for NonProfitIati", group =>
            {
			    HumanitarianScopeId = group.Add(new VocabularyKey(nameof(HumanitarianScopeId), "Humanitarian Scope", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey HumanitarianScopeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}