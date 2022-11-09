using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendProspectiveVendorRegistrationProcurementCategoryEntityVocabulary : SimpleVocabulary
    {
        public VendProspectiveVendorRegistrationProcurementCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendProspectiveVendorRegistrationProcurementCategoryEntity";
            KeyPrefix = "commonDataModel.vendprospectivevendorregistrationprocurementcategoryentity";
            KeySeparator = ".";
            Grouping = "/VendProspectiveVendorRegistrationProcurementCategoryEntity";

            AddGroup("Common Data Model VendProspectiveVendorRegistrationProcurementCategoryEntity Details", group =>
            {
                CategoryStatus = group.Add(new VocabularyKey(nameof(CategoryStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonEmailAddress = group.Add(new VocabularyKey(nameof(ContactPersonEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorRegistrationId = group.Add(new VocabularyKey(nameof(VendorRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CategoryStatus { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey ContactPersonEmailAddress { get; private set; }
public VocabularyKey CategoryName { get; private set; }
public VocabularyKey VendorRegistrationId { get; private set; }
public VocabularyKey CategoryHierarchyName { get; private set; }


    }
}