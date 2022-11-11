using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSCarrierFuelIndexEntityVocabulary : SimpleVocabulary
    {
        public TMSCarrierFuelIndexEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSCarrierFuelIndexEntity";
            KeyPrefix = "commonDataModel.tmscarrierfuelindexentity";
            KeySeparator = ".";
            Grouping = "/TMSCarrierFuelIndexEntity";

            AddGroup("Common Data Model TMSCarrierFuelIndexEntity Details", group =>
            {
                IndexCode = group.Add(new VocabularyKey(nameof(IndexCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndexDescription = group.Add(new VocabularyKey(nameof(IndexDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IndexCode { get; private set; }
        public VocabularyKey IndexDescription { get; private set; }


    }
}