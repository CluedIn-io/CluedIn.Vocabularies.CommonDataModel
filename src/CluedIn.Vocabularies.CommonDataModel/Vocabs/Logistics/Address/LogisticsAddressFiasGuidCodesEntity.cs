using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressFiasGuidCodesEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressFiasGuidCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsAddressFiasGuidCodesEntity";
            KeyPrefix = "commonDataModel.logisticsaddressfiasguidcodesentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressFiasGuidCodesEntity";

            AddGroup("Common Data Model LogisticsAddressFiasGuidCodesEntity Details", group =>
            {
                FiasGuidId = group.Add(new VocabularyKey(nameof(FiasGuidId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiasParentGuidId = group.Add(new VocabularyKey(nameof(FiasParentGuidId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionId = group.Add(new VocabularyKey(nameof(VersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiasGuidId { get; private set; }
        public VocabularyKey FiasParentGuidId { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey RefTableId { get; private set; }
        public VocabularyKey VersionId { get; private set; }


    }
}