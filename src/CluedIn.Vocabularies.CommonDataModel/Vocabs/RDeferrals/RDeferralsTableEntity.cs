using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsTableEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsTableEntityVocabulary()
        {
            VocabularyName = "R Deferrals Table Entity";
            KeyPrefix = "commonDataModel.rdeferralstableentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsTableEntity";

            AddGroup("RDeferralsTableEntity Details", group =>
            {
                DateAttached = group.Add(new VocabularyKey(nameof(DateAttached), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferralId = group.Add(new VocabularyKey(nameof(DeferralId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode = group.Add(new VocabularyKey(nameof(ExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATOffsetMethodForDeferrals = group.Add(new VocabularyKey(nameof(VATOffsetMethodForDeferrals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DateAttached { get; private set; }
        public VocabularyKey DeferralId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey ExpenseCode { get; private set; }
        public VocabularyKey VATOffsetMethodForDeferrals { get; private set; }
    }
}