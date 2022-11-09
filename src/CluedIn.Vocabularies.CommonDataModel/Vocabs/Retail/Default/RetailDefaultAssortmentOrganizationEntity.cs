using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDefaultAssortmentOrganizationEntityVocabulary : SimpleVocabulary
    {
        public RetailDefaultAssortmentOrganizationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailDefaultAssortmentOrganizationEntity";
            KeyPrefix = "commonDataModel.retaildefaultassortmentorganizationentity";
            KeySeparator = ".";
            Grouping = "/RetailDefaultAssortmentOrganizationEntity";

            AddGroup("Common Data Model RetailDefaultAssortmentOrganizationEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationPartyNumber = group.Add(new VocabularyKey(nameof(OrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey OrganizationName { get; private set; }
public VocabularyKey OrganizationPartyNumber { get; private set; }


    }
}