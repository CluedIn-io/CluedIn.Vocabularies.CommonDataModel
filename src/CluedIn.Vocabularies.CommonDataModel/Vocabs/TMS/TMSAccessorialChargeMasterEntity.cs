using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSAccessorialChargeMasterEntityVocabulary : SimpleVocabulary
    {
        public TMSAccessorialChargeMasterEntityVocabulary()
        {
            VocabularyName = "TMSAccessorialChargeMasterEntity";
            KeyPrefix = "commonDataModel.tmsaccessorialchargemasterentity";
            KeySeparator = ".";
            Grouping = "/TMSAccessorialChargeMasterEntity";

            AddGroup("TMSAccessorialChargeMasterEntity Details", group =>
            {
                MasterCode = group.Add(new VocabularyKey(nameof(MasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeMasterType = group.Add(new VocabularyKey(nameof(ChargeMasterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterDescription = group.Add(new VocabularyKey(nameof(MasterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MasterCode { get; private set; }
        public VocabularyKey ChargeMasterType { get; private set; }
        public VocabularyKey MasterDescription { get; private set; }


    }
}