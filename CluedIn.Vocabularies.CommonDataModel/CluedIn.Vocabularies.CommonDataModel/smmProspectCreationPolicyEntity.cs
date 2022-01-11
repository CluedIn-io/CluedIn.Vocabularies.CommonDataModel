using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmProspectCreationPolicyEntityVocabulary : SimpleVocabulary
    {
        public smmProspectCreationPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmProspectCreationPolicyEntity";
            KeyPrefix = "commonDataModel.smmprospectcreationpolicyentity";
            KeySeparator = ".";
            Grouping = "/smmProspectCreationPolicyEntity";

            AddGroup("Common Data Model smmProspectCreationPolicyEntity Details", group =>
            {
                DefaultProspectRelationTypeId = group.Add(new VocabularyKey(nameof(DefaultProspectRelationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLanguageId = group.Add(new VocabularyKey(nameof(DefaultLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVendorGroupId = group.Add(new VocabularyKey(nameof(DefaultVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCustomerGroupId = group.Add(new VocabularyKey(nameof(DefaultCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCurrencyCode = group.Add(new VocabularyKey(nameof(DefaultCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBusinessOpeningTime = group.Add(new VocabularyKey(nameof(DefaultBusinessOpeningTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBusinessClosingTime = group.Add(new VocabularyKey(nameof(DefaultBusinessClosingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultProspectStatusId = group.Add(new VocabularyKey(nameof(DefaultProspectStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillProspectConversionOpenRelationTypeForm = group.Add(new VocabularyKey(nameof(WillProspectConversionOpenRelationTypeForm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DefaultProspectRelationTypeId { get; private set; }
public VocabularyKey DefaultLanguageId { get; private set; }
public VocabularyKey DefaultVendorGroupId { get; private set; }
public VocabularyKey DefaultCustomerGroupId { get; private set; }
public VocabularyKey DefaultCurrencyCode { get; private set; }
public VocabularyKey DefaultBusinessOpeningTime { get; private set; }
public VocabularyKey DefaultBusinessClosingTime { get; private set; }
public VocabularyKey DefaultProspectStatusId { get; private set; }
public VocabularyKey WillProspectConversionOpenRelationTypeForm { get; private set; }


    }
}