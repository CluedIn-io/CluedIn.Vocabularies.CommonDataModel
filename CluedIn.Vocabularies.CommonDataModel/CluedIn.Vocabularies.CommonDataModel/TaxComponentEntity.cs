using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxComponentEntityVocabulary : SimpleVocabulary
    {
        public TaxComponentEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxComponentEntity";
            KeyPrefix = "commonDataModel.taxcomponententity";
            KeySeparator = ".";
            Grouping = "/TaxComponentEntity";

            AddGroup("Common Data Model TaxComponentEntity Details", group =>
            {
                ApplyExcise = group.Add(new VocabularyKey(nameof(ApplyExcise), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxComponent = group.Add(new VocabularyKey(nameof(TaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ApplyExcise { get; private set; }
public VocabularyKey TaxComponent { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey TaxType { get; private set; }


    }
}