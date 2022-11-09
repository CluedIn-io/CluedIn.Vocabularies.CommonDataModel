using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvSharedSubCategoryEntityVocabulary : SimpleVocabulary
    {
        public TrvSharedSubCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvSharedSubCategoryEntity";
            KeyPrefix = "commonDataModel.trvsharedsubcategoryentity";
            KeySeparator = ".";
            Grouping = "/TrvSharedSubCategoryEntity";

            AddGroup("Common Data Model TrvSharedSubCategoryEntity Details", group =>
            {
                ChargeType = group.Add(new VocabularyKey(nameof(ChargeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExcludeFromRecovery = group.Add(new VocabularyKey(nameof(ExcludeFromRecovery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SharedCategory = group.Add(new VocabularyKey(nameof(SharedCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SystemCreated = group.Add(new VocabularyKey(nameof(SystemCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SharedCategoryId = group.Add(new VocabularyKey(nameof(SharedCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ChargeType { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ExcludeFromRecovery { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey SharedCategory { get; private set; }
public VocabularyKey SystemCreated { get; private set; }
public VocabularyKey SharedCategoryId { get; private set; }


    }
}