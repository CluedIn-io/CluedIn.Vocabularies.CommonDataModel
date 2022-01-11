using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormPageTemplateVocabulary : SimpleVocabulary
    {
        public FormPageTemplateVocabulary()
        {
            VocabularyName = "Common Data Model FormPageTemplate";
            KeyPrefix = "commonDataModel.formpagetemplate";
            KeySeparator = ".";
            Grouping = "/FormPageTemplate";

            AddGroup("Common Data Model FormPageTemplate Details", group =>
            {
                confirmationMessage = group.Add(new VocabularyKey(nameof(confirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
errorMessage = group.Add(new VocabularyKey(nameof(errorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
formPageTemplateId = group.Add(new VocabularyKey(nameof(formPageTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
limitExceededMessage = group.Add(new VocabularyKey(nameof(limitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
redirectURL = group.Add(new VocabularyKey(nameof(redirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
successImageURL = group.Add(new VocabularyKey(nameof(successImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
errorImageURL = group.Add(new VocabularyKey(nameof(errorImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey confirmationMessage { get; private set; }
public VocabularyKey errorMessage { get; private set; }
public VocabularyKey formPageTemplateId { get; private set; }
public VocabularyKey limitExceededMessage { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey redirectURL { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey successImageURL { get; private set; }
public VocabularyKey errorImageURL { get; private set; }


    }
}