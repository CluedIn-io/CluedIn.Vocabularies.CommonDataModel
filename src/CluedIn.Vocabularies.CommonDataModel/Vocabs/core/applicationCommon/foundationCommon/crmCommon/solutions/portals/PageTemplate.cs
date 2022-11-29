using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class PageTemplateVocabulary : SimpleVocabulary
    {
        public PageTemplateVocabulary()
        {
            VocabularyName = "Page Template";
            KeyPrefix = "commonDataModel.pagetemplate.portals";
            KeySeparator = ".";
            Grouping = "/PageTemplate";

            AddGroup("PageTemplate Details for Portals", group =>
            {
			    PageTemplateId = group.Add(new VocabularyKey(nameof(PageTemplateId), "Page Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RewriteURL = group.Add(new VocabularyKey(nameof(RewriteURL), "Rewrite Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityName = group.Add(new VocabularyKey(nameof(EntityName), "Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UseWebsiteHeaderAndFooter = group.Add(new VocabularyKey(nameof(UseWebsiteHeaderAndFooter), "Use Website Header and Footer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PageTemplateId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey RewriteURL { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey UseWebsiteHeaderAndFooter { get; private set; }
    }
}