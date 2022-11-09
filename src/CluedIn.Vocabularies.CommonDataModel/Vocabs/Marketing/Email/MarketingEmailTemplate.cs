using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTemplateVocabulary : SimpleVocabulary
    {
        public MarketingEmailTemplateVocabulary()
        {
            VocabularyName = "Common Data Model MarketingEmailTemplate";
            KeyPrefix = "commonDataModel.marketingemailtemplate";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTemplate";

            AddGroup("Common Data Model MarketingEmailTemplate Details", group =>
            {
                formToSave = group.Add(new VocabularyKey(nameof(formToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sourceEmailID = group.Add(new VocabularyKey(nameof(sourceEmailID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
designerHTML = group.Add(new VocabularyKey(nameof(designerHTML), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
emailTemplateMarketTypeOptionset = group.Add(new VocabularyKey(nameof(emailTemplateMarketTypeOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
emailTemplateOptimizedforOptionset = group.Add(new VocabularyKey(nameof(emailTemplateOptimizedforOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
emailTemplatePurposeOptionset = group.Add(new VocabularyKey(nameof(emailTemplatePurposeOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
emailTemplateVisualStyleOptionset = group.Add(new VocabularyKey(nameof(emailTemplateVisualStyleOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
emailBody = group.Add(new VocabularyKey(nameof(emailBody), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
language = group.Add(new VocabularyKey(nameof(language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingEmailTemplateId = group.Add(new VocabularyKey(nameof(marketingEmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingProvided = group.Add(new VocabularyKey(nameof(marketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
emailContenttype = group.Add(new VocabularyKey(nameof(emailContenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
messagedesignation = group.Add(new VocabularyKey(nameof(messagedesignation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
subject = group.Add(new VocabularyKey(nameof(subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
textpart = group.Add(new VocabularyKey(nameof(textpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
automaticallyGenerateTextPart = group.Add(new VocabularyKey(nameof(automaticallyGenerateTextPart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
tag = group.Add(new VocabularyKey(nameof(tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
label = group.Add(new VocabularyKey(nameof(label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
fromEmail = group.Add(new VocabularyKey(nameof(fromEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
fromName = group.Add(new VocabularyKey(nameof(fromName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
to = group.Add(new VocabularyKey(nameof(to), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
replyToEmail = group.Add(new VocabularyKey(nameof(replyToEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey formToSave { get; private set; }
public VocabularyKey entityImage { get; private set; }
public VocabularyKey sourceEmailID { get; private set; }
public VocabularyKey designerHTML { get; private set; }
public VocabularyKey emailTemplateMarketTypeOptionset { get; private set; }
public VocabularyKey emailTemplateOptimizedforOptionset { get; private set; }
public VocabularyKey emailTemplatePurposeOptionset { get; private set; }
public VocabularyKey emailTemplateVisualStyleOptionset { get; private set; }
public VocabularyKey emailBody { get; private set; }
public VocabularyKey language { get; private set; }
public VocabularyKey marketingEmailTemplateId { get; private set; }
public VocabularyKey marketingProvided { get; private set; }
public VocabularyKey emailContenttype { get; private set; }
public VocabularyKey messagedesignation { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey subject { get; private set; }
public VocabularyKey textpart { get; private set; }
public VocabularyKey automaticallyGenerateTextPart { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey tag { get; private set; }
public VocabularyKey label { get; private set; }
public VocabularyKey fromEmail { get; private set; }
public VocabularyKey fromName { get; private set; }
public VocabularyKey to { get; private set; }
public VocabularyKey replyToEmail { get; private set; }


    }
}