using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInternalOrganizationEntityVocabulary : SimpleVocabulary
    {
        public RetailInternalOrganizationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInternalOrganizationEntity";
            KeyPrefix = "commonDataModel.retailinternalorganizationentity";
            KeySeparator = ".";
            Grouping = "/RetailInternalOrganizationEntity";

            AddGroup("Common Data Model RetailInternalOrganizationEntity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InheritEnabled = group.Add(new VocabularyKey(nameof(InheritEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PartyNumber { get; private set; }
public VocabularyKey OrganizationName { get; private set; }
public VocabularyKey CategoryHierarchyName { get; private set; }
public VocabularyKey InheritEnabled { get; private set; }


    }
}