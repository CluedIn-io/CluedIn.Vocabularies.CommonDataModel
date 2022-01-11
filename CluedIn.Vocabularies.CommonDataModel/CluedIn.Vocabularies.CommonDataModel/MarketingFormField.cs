using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormFieldVocabulary : SimpleVocabulary
    {
        public MarketingFormFieldVocabulary()
        {
            VocabularyName = "Common Data Model MarketingFormField";
            KeyPrefix = "commonDataModel.marketingformfield";
            KeySeparator = ".";
            Grouping = "/MarketingFormField";

            AddGroup("Common Data Model MarketingFormField Details", group =>
            {
                contactMapping = group.Add(new VocabularyKey(nameof(contactMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
defaultformlabel = group.Add(new VocabularyKey(nameof(defaultformlabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
defaultformplaceholder = group.Add(new VocabularyKey(nameof(defaultformplaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingFormFieldId = group.Add(new VocabularyKey(nameof(marketingFormFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingformfieldtype = group.Add(new VocabularyKey(nameof(marketingformfieldtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
format = group.Add(new VocabularyKey(nameof(format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadMapping = group.Add(new VocabularyKey(nameof(leadMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
renderas = group.Add(new VocabularyKey(nameof(renderas), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingProvided = group.Add(new VocabularyKey(nameof(marketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactmappingTarget = group.Add(new VocabularyKey(nameof(contactmappingTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadmappingTarget = group.Add(new VocabularyKey(nameof(leadmappingTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lookupTarget = group.Add(new VocabularyKey(nameof(lookupTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
prototypeAttribute = group.Add(new VocabularyKey(nameof(prototypeAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
prototypeEntity = group.Add(new VocabularyKey(nameof(prototypeEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
prototypeTarget = group.Add(new VocabularyKey(nameof(prototypeTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
publicVisibility = group.Add(new VocabularyKey(nameof(publicVisibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey contactMapping { get; private set; }
public VocabularyKey defaultformlabel { get; private set; }
public VocabularyKey defaultformplaceholder { get; private set; }
public VocabularyKey marketingFormFieldId { get; private set; }
public VocabularyKey marketingformfieldtype { get; private set; }
public VocabularyKey format { get; private set; }
public VocabularyKey leadMapping { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey renderas { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey marketingProvided { get; private set; }
public VocabularyKey contactmappingTarget { get; private set; }
public VocabularyKey leadmappingTarget { get; private set; }
public VocabularyKey lookupTarget { get; private set; }
public VocabularyKey prototypeAttribute { get; private set; }
public VocabularyKey prototypeEntity { get; private set; }
public VocabularyKey prototypeTarget { get; private set; }
public VocabularyKey publicVisibility { get; private set; }


    }
}