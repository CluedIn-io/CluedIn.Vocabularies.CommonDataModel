using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReport347AddressAbbreviationEntityVocabulary : SimpleVocabulary
    {
        public TaxReport347AddressAbbreviationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxReport347AddressAbbreviationEntity";
            KeyPrefix = "commonDataModel.taxreport347addressabbreviationentity";
            KeySeparator = ".";
            Grouping = "/TaxReport347AddressAbbreviationEntity";

            AddGroup("Common Data Model TaxReport347AddressAbbreviationEntity Details", group =>
            {
                AddressAbbreviation = group.Add(new VocabularyKey(nameof(AddressAbbreviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AddressAbbreviation { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}