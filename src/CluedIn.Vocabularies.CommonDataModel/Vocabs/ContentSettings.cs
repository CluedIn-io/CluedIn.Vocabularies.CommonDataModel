using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ContentSettingsVocabulary : SimpleVocabulary
    {
        public ContentSettingsVocabulary()
        {
            VocabularyName = "Content Settings";
            KeyPrefix = "commonDataModel.contentsettings";
            KeySeparator = ".";
            Grouping = "/ContentSettings";

            AddGroup("ContentSettings Details", group =>
            {
                AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressMain = group.Add(new VocabularyKey(nameof(AddressMain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContentSettingsId = group.Add(new VocabularyKey(nameof(ContentSettingsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                @Default = group.Add(new VocabularyKey(nameof(@Default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Isbusinessunitdefault = group.Add(new VocabularyKey(nameof(Isbusinessunitdefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FacebookURL = group.Add(new VocabularyKey(nameof(FacebookURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForwardToAFriend = group.Add(new VocabularyKey(nameof(ForwardToAFriend), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInURL = group.Add(new VocabularyKey(nameof(LinkedInURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubscriptionCenter = group.Add(new VocabularyKey(nameof(SubscriptionCenter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TwitterURL = group.Add(new VocabularyKey(nameof(TwitterURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstagramURL = group.Add(new VocabularyKey(nameof(InstagramURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MediumURL = group.Add(new VocabularyKey(nameof(MediumURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkypeURL = group.Add(new VocabularyKey(nameof(SkypeURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GooglePlusURL = group.Add(new VocabularyKey(nameof(GooglePlusURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YouTubeURL = group.Add(new VocabularyKey(nameof(YouTubeURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressMain { get; private set; }
        public VocabularyKey ContentSettingsId { get; private set; }
        public VocabularyKey @Default { get; private set; }
        public VocabularyKey Isbusinessunitdefault { get; private set; }
        public VocabularyKey FacebookURL { get; private set; }
        public VocabularyKey ForwardToAFriend { get; private set; }
        public VocabularyKey LinkedInURL { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SubscriptionCenter { get; private set; }
        public VocabularyKey TwitterURL { get; private set; }
        public VocabularyKey InstagramURL { get; private set; }
        public VocabularyKey MediumURL { get; private set; }
        public VocabularyKey SkypeURL { get; private set; }
        public VocabularyKey GooglePlusURL { get; private set; }
        public VocabularyKey YouTubeURL { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}