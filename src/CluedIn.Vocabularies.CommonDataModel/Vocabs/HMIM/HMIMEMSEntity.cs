using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMEMSEntityVocabulary : SimpleVocabulary
    {
        public HMIMEMSEntityVocabulary()
        {
            VocabularyName = "HMIMEMS Entity";
            KeyPrefix = "commonDataModel.hmimemsentity";
            KeySeparator = ".";
            Grouping = "/HMIMEMSEntity";

            AddGroup("HMIMEMSEntity Details", group =>
            {
                EMSCode = group.Add(new VocabularyKey(nameof(EMSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EMSCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}