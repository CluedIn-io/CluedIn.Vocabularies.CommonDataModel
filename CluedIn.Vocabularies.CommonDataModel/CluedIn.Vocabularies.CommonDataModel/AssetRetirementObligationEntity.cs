using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetRetirementObligationEntityVocabulary : SimpleVocabulary
    {
        public AssetRetirementObligationEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetRetirementObligationEntity";
            KeyPrefix = "commonDataModel.assetretirementobligationentity";
            KeySeparator = ".";
            Grouping = "/AssetRetirementObligationEntity";

            AddGroup("Common Data Model AssetRetirementObligationEntity Details", group =>
            {
                AssetNumber = group.Add(new VocabularyKey(nameof(AssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Book = group.Add(new VocabularyKey(nameof(Book), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceLife = group.Add(new VocabularyKey(nameof(ServiceLife), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentId = group.Add(new VocabularyKey(nameof(DocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingFrequency = group.Add(new VocabularyKey(nameof(PostingFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AssetNumber { get; private set; }
public VocabularyKey Book { get; private set; }
public VocabularyKey ServiceLife { get; private set; }
public VocabularyKey DocumentId { get; private set; }
public VocabularyKey DocumentDate { get; private set; }
public VocabularyKey PostingFrequency { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}