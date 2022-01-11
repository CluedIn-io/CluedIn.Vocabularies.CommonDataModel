using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductEntityIdentifierCodeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductEntityIdentifierCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductEntityIdentifierCodeEntity";
            KeyPrefix = "commonDataModel.ecoresproductentityidentifiercodeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductEntityIdentifierCodeEntity";

            AddGroup("Common Data Model EcoResProductEntityIdentifierCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Id = group.Add(new VocabularyKey(nameof(Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Id { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}