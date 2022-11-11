using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDlvModeChannelExplodedEntityVocabulary : SimpleVocabulary
    {
        public RetailDlvModeChannelExplodedEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailDlvModeChannelExplodedEntity";
            KeyPrefix = "commonDataModel.retaildlvmodechannelexplodedentity";
            KeySeparator = ".";
            Grouping = "/RetailDlvModeChannelExplodedEntity";

            AddGroup("Common Data Model RetailDlvModeChannelExplodedEntity Details", group =>
            {
                DlvMode = group.Add(new VocabularyKey(nameof(DlvMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnit = group.Add(new VocabularyKey(nameof(OMOperatingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DlvMode_Code = group.Add(new VocabularyKey(nameof(DlvMode_Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DlvMode { get; private set; }
        public VocabularyKey OMOperatingUnit { get; private set; }
        public VocabularyKey DlvMode_Code { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}