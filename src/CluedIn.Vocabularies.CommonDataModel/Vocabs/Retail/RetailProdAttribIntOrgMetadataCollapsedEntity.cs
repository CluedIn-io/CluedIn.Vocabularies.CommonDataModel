using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailProdAttribIntOrgMetadataCollapsedEntityVocabulary : SimpleVocabulary
    {
        public RetailProdAttribIntOrgMetadataCollapsedEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailProdAttribIntOrgMetadataCollapsedEntity";
            KeyPrefix = "commonDataModel.retailprodattribintorgmetadatacollapsedentity";
            KeySeparator = ".";
            Grouping = "/RetailProdAttribIntOrgMetadataCollapsedEntity";

            AddGroup("Common Data Model RetailProdAttribIntOrgMetadataCollapsedEntity Details", group =>
            {
                AttributeRelationType = group.Add(new VocabularyKey(nameof(AttributeRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Distance = group.Add(new VocabularyKey(nameof(Distance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRequired = group.Add(new VocabularyKey(nameof(IsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KeyName = group.Add(new VocabularyKey(nameof(KeyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Metadata = group.Add(new VocabularyKey(nameof(Metadata), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MetadataVersion = group.Add(new VocabularyKey(nameof(MetadataVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginRecVersion = group.Add(new VocabularyKey(nameof(OriginRecVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InternalOrganizationNumber = group.Add(new VocabularyKey(nameof(InternalOrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AttributeRelationType { get; private set; }
public VocabularyKey Distance { get; private set; }
public VocabularyKey IsRequired { get; private set; }
public VocabularyKey KeyName { get; private set; }
public VocabularyKey Metadata { get; private set; }
public VocabularyKey MetadataVersion { get; private set; }
public VocabularyKey OriginRecVersion { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey InternalOrganizationNumber { get; private set; }


    }
}