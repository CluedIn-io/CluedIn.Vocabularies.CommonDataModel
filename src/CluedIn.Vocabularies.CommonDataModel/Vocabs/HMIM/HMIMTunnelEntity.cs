using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMTunnelEntityVocabulary : SimpleVocabulary
    {
        public HMIMTunnelEntityVocabulary()
        {
            VocabularyName = "Common Data Model HMIMTunnelEntity";
            KeyPrefix = "commonDataModel.hmimtunnelentity";
            KeySeparator = ".";
            Grouping = "/HMIMTunnelEntity";

            AddGroup("Common Data Model HMIMTunnelEntity Details", group =>
            {
                TunnelCode = group.Add(new VocabularyKey(nameof(TunnelCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TunnelCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}