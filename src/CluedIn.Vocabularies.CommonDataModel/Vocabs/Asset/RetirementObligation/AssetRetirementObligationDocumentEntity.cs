using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetRetirementObligationDocumentEntityVocabulary : SimpleVocabulary
    {
        public AssetRetirementObligationDocumentEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetRetirementObligationDocumentEntity";
            KeyPrefix = "commonDataModel.assetretirementobligationdocumententity";
            KeySeparator = ".";
            Grouping = "/AssetRetirementObligationDocumentEntity";

            AddGroup("Common Data Model AssetRetirementObligationDocumentEntity Details", group =>
            {
                AssetDocumentRecId = group.Add(new VocabularyKey(nameof(AssetDocumentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingFrequency = group.Add(new VocabularyKey(nameof(PostingFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentId = group.Add(new VocabularyKey(nameof(DocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssetDocumentRecId { get; private set; }
        public VocabularyKey PostingFrequency { get; private set; }
        public VocabularyKey DocumentId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }


    }
}