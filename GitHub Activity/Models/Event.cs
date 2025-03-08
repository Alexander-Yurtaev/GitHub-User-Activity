using Newtonsoft.Json;

namespace GitHub_Activity.Models;

public class Event
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("actor")]
    public Actor Actor { get; set; }

    [JsonProperty("repo")]
    public Repo Repo { get; set; }

    [JsonProperty("payload")]
    public Payload Payload { get; set; }

    [JsonProperty("public")]
    public bool Public { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("org")]
    public Org Org { get; set; }
}

public class Actor
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("display_login")]
    public string DisplayLogin { get; set; }

    [JsonProperty("gravatar_id")]
    public string GravatarId { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }
}

public class Repo
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("full_name")]
    public string FullName { get; set; }

    [JsonProperty("private")]
    public bool Private { get; set; }

    [JsonProperty("owner")]
    public Owner Owner { get; set; }

    [JsonProperty("html_url")]
    public string Html_url { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("fork")]
    public bool Fork { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("forks_url")]
    public string ForksUrl { get; set; }

    [JsonProperty("keys_url")]
    public string KeysUrl { get; set; }

    [JsonProperty("collaborators_url")]
    public string CollaboratorsUrl { get; set; }

    [JsonProperty("teams_url")]
    public string TeamsUrl { get; set; }

    [JsonProperty("hooks_url")]
    public string HooksUrl { get; set; }

    [JsonProperty("issue_events_url")]
    public string IssueEventsUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("assignees_url")]
    public string AssigneesUrl { get; set; }

    [JsonProperty("branches_url")]
    public string BranchesUrl { get; set; }

    [JsonProperty("tags_url")]
    public string TagsUrl { get; set; }

    [JsonProperty("blobs_url")]
    public string BlobsUrl { get; set; }

    [JsonProperty("git_tags_url")]
    public string GitTagsUrl { get; set; }

    [JsonProperty("git_refs_url")]
    public string GitRefsUrl { get; set; }

    [JsonProperty("trees_url")]
    public string TreesUrl { get; set; }

    [JsonProperty("statuses_url")]
    public string StatusesUrl { get; set; }
    
    
    public string languages_url { get; set; }
    
    
    public string stargazers_url { get; set; }
    
    
    public string contributors_url { get; set; }
    
    
    public string subscribers_url { get; set; }
    
    
    public string subscription_url { get; set; }
    
    
    public string commits_url { get; set; }
    
    
    public string git_commits_url { get; set; }
    
    
    public string comments_url { get; set; }
    
    
    public string issue_comment_url { get; set; }
    
    
    public string contents_url { get; set; }
    
    
    public string compare_url { get; set; }
    
    
    public string merges_url { get; set; }
    
    
    public string archive_url { get; set; }
    
    
    public string downloads_url { get; set; }
    
    
    public string issues_url { get; set; }
    
    
    public string pulls_url { get; set; }
    
    
    public string milestones_url { get; set; }
    
    
    public string notifications_url { get; set; }
    
    
    public string labels_url { get; set; }
    
    
    public string releases_url { get; set; }
    
    
    public string deployments_url { get; set; }
    
    
    public DateTime created_at { get; set; }
    
    
    public DateTime updated_at { get; set; }
    
    
    public DateTime pushed_at { get; set; }
    
    
    public string git_url { get; set; }
    
    
    public string ssh_url { get; set; }
    
    
    public string clone_url { get; set; }
    
    
    public string svn_url { get; set; }
    
    
    public string homepage { get; set; }
    
    
    public int size { get; set; }
    
    
    public int stargazers_count { get; set; }
    
    
    public int watchers_count { get; set; }
    
    
    public string language { get; set; }
    
    
    public bool has_issues { get; set; }
    
    
    public bool has_projects { get; set; }
    
    
    public bool has_downloads { get; set; }
    
    
    
    public bool has_wiki { get; set; }
    
    
    public bool has_pages { get; set; }
    
    
    public bool has_discussions { get; set; }
    
    
    public int forks_count { get; set; }
    
    
    public object mirror_url { get; set; }
    
    
    public bool archived { get; set; }
    
    
    public bool disabled { get; set; }
    
    
    public int open_issues_count { get; set; }
    
    
    public License license { get; set; }
    
    
    public bool allow_forking { get; set; }
    
    
    public bool is_template { get; set; }
    
    
    public bool web_commit_signoff_required { get; set; }
    
    
    public string[] topics { get; set; }
    
    
    public string visibility { get; set; }
    
    
    public int forks { get; set; }
    
    
    public int open_issues { get; set; }
    
    
    public int watchers { get; set; }
    
    
    public string default_branch { get; set; }
}

public class Payload
{
    [JsonProperty("action")]
    public string Action { get; set; }

    [JsonProperty("repository_id")]
    public int RepositoryId { get; set; }

    [JsonProperty("push_id")]
    public long PushId { get; set; }

    [JsonProperty("size")]
    public int Size { get; set; }

    [JsonProperty("distinct_size")]
    public int DistinctSize { get; set; }

    [JsonProperty("ref")]
    public string Ref { get; set; }

    [JsonProperty("head")]
    public string Head { get; set; }

    [JsonProperty("before")]
    public string Before { get; set; }

    [JsonProperty("commits")]
    public Commit[] Commits { get; set; }

    [JsonProperty("ref_type")]
    public string RefType { get; set; }

    [JsonProperty("pusher_type")]
    public string PusherType { get; set; }

    [JsonProperty("master_branch")]
    public string MasterBranch { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("issue")]
    public Issue Issue { get; set; }

    [JsonProperty("comment")]
    public Comment Comment { get; set; }

    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("pull_request")]
    public PullRequest PullRequest { get; set; }
}

public class Issue
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("repository_url")]
    public string RepositoryUrl { get; set; }

    [JsonProperty("labels_url")]
    public string LabelsUrl { get; set; }

    [JsonProperty("comments_url")]
    public string CommentsUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    [JsonProperty("labels")]
    public Label[] Labels { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("locked")]
    public bool Locked { get; set; }

    [JsonProperty("assignee")]
    public object Assignee { get; set; }

    [JsonProperty("assignees")]
    public object[] Assignees { get; set; }

    [JsonProperty("milestone")]
    public object Milestone { get; set; }

    [JsonProperty("comments")]
    public int comments { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("closed_at")]
    public DateTime ClosedAt { get; set; }

    [JsonProperty("author_association")]
    public string AuthorAssociation { get; set; }

    [JsonProperty("sub_issues_summary")]
    public SubIssuesSummary SubIssuesSummary { get; set; }

    [JsonProperty("active_lock_reason")]
    public object ActiveLockReason { get; set; }

    [JsonProperty("body")]
    public string Body { get; set; }

    [JsonProperty("reactions")]
    public Reactions Reactions { get; set; }

    [JsonProperty("timeline_url")]
    public string TimelineUrl { get; set; }

    [JsonProperty("performed_via_github_app")]
    public object PerformedViaGithubApp { get; set; }

    [JsonProperty("state_reason")]
    public string StateReason { get; set; }

    [JsonProperty("href")]
    public string Href { get; set; }
}

public class User
{
    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("gravatar_id")]
    public string GravatarId { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("followers_url")]
    public string FollowersUrl { get; set; }

    [JsonProperty("following_url")]
    public string FollowingUrl { get; set; }

    [JsonProperty("gists_url")]
    public string GistsUrl { get; set; }

    [JsonProperty("starred_url")]
    public string StarredUrl { get; set; }

    [JsonProperty("subscriptions_url")]
    public string SubscriptionsUrl { get; set; }

    [JsonProperty("organizations_url")]
    public string OrganizationsUrl { get; set; }

    [JsonProperty("repos_url")]
    public string ReposUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("received_events_url")]
    public string ReceivedEventsUrl { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("user_view_type")]
    public string UserViewType { get; set; }

    [JsonProperty("site_admin")]
    public bool SiteAdmin { get; set; }
}

public class SubIssuesSummary
{
    [JsonProperty("total")]
    public int Total { get; set; }

    [JsonProperty("completed")]
    public int Completed { get; set; }

    [JsonProperty("percent_completed")]
    public int PercentCompleted { get; set; }
}

public class Reactions
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("total_count")]
    public int TotalCount { get; set; }

    [JsonProperty("-1")]
    public int _minus_1 { get; set; }

    [JsonProperty("+1")]
    public int _plus_1 { get; set; }

    [JsonProperty("laugh")]
    public int Laugh { get; set; }

    [JsonProperty("hooray")]
    public int Hooray { get; set; }

    [JsonProperty("confused")]
    public int Confused { get; set; }

    [JsonProperty("heart")]
    public int Heart { get; set; }

    [JsonProperty("rocket")]
    public int Rocket { get; set; }

    [JsonProperty("eyes")]
    public int Eyes { get; set; }
}

public class Label
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("color")]
    public string Color { get; set; }

    [JsonProperty("default")]
    public bool Default { get; set; }

    [JsonProperty("description")]
    public object Description { get; set; }
}

public class Comment
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("issue_url")]
    public string IssueUrl { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("author_association")]
    public string AuthorAssociation { get; set; }

    [JsonProperty("body")]
    public string Body { get; set; }

    [JsonProperty("reactions")]
    public Reactions Reactions { get; set; }

    [JsonProperty("performed_via_github_app")]
    public object PerformedViaGithubApp { get; set; }
}

public class PullRequest
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("diff_url")]
    public string DiffUrl { get; set; }

    [JsonProperty("patch_url")]
    public string PatchUrl { get; set; }

    [JsonProperty("issue_url")]
    public string IssueUrl { get; set; }

    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("locked")]
    public bool Locked { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    [JsonProperty("body")]
    public string Body { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("closed_at")]
    public DateTime? ClosedAt { get; set; }

    [JsonProperty("merged_at")]
    public DateTime? MergedAt { get; set; }

    [JsonProperty("merge_commit_sha")]
    public string MergeCommitSha { get; set; }

    [JsonProperty("assignee")]
    public object Assignee { get; set; }

    [JsonProperty("assignees")]
    public object[] Assignees { get; set; }

    [JsonProperty("requested_reviewers")]
    public RequestedReviewers[] RequestedReviewers { get; set; }

    [JsonProperty("requested_teams")]
    public object[] RequestedTeams { get; set; }

    [JsonProperty("labels")]
    public Label[] Labels { get; set; }

    [JsonProperty("milestone")]
    public object Milestone { get; set; }

    [JsonProperty("draft")]
    public bool Draft { get; set; }

    [JsonProperty("commits_url")]
    public string CommitsUrl { get; set; }

    [JsonProperty("review_comments_url")]
    public string ReviewCommentsUrl { get; set; }

    [JsonProperty("review_comment_url")]
    public string ReviewCommentUrl { get; set; }

    [JsonProperty("comments_url")]
    public string CommentsUrl { get; set; }

    [JsonProperty("statuses_url")]
    public string StatusesUrl { get; set; }

    [JsonProperty("head")]
    public Head Head { get; set; }

    [JsonProperty("base")]
    public Base Base { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }

    [JsonProperty("author_association")]
    public string AuthorAssociation { get; set; }

    [JsonProperty("auto_merge")]
    public object AutoMerge { get; set; }

    [JsonProperty("active_lock_reason")]
    public object ActiveLockReason { get; set; }

    [JsonProperty("merged")]
    public bool Merged { get; set; }

    [JsonProperty("mergeable")]
    public object Mergeable { get; set; }

    [JsonProperty("rebaseable")]
    public object Rebaseable { get; set; }

    [JsonProperty("mergeable_state")]
    public string MergeableState { get; set; }

    [JsonProperty("merged_by")]
    public MergedBy MergedBy { get; set; }

    [JsonProperty("comments")]
    public int Comments { get; set; }

    [JsonProperty("review_comments")]
    public int ReviewComments { get; set; }

    [JsonProperty("maintainer_can_modify")]
    public bool MaintainerCanModify { get; set; }

    [JsonProperty("commits")]
    public int Commits { get; set; }

    [JsonProperty("additions")]
    public int Additions { get; set; }

    [JsonProperty("deletions")]
    public int Deletions { get; set; }

    [JsonProperty("changed_files")]
    public int ChangedFiles { get; set; }
}

public class Head
{
    [JsonProperty("label")]
    public string Label { get; set; }

    [JsonProperty("ref")]
    public string Ref { get; set; }

    [JsonProperty("sha")]
    public string Sha { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    [JsonProperty("repo")]
    public Repo Repo { get; set; }
}

public class Owner
{
    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("gravatar_id")]
    public string GravatarId { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("followers_url")]
    public string FollowersUrl { get; set; }

    [JsonProperty("following_url")]
    public string FollowingUrl { get; set; }

    [JsonProperty("gists_url")]
    public string GistsUrl { get; set; }

    [JsonProperty("starred_url")]
    public string StarredUrl { get; set; }

    [JsonProperty("subscriptions_url")]
    public string SubscriptionsUrl { get; set; }

    [JsonProperty("organizations_url")]
    public string OrganizationsUrl { get; set; }

    [JsonProperty("repos_url")]
    public string ReposUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("received_events_url")]
    public string ReceivedEventsUrl { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("user_view_type")]
    public string UserViewType { get; set; }

    [JsonProperty("site_admin")]
    public bool SiteAdmin { get; set; }
}

public class License
{
    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("spdx_id")]
    public string SpdxId { get; set; }

    [JsonProperty("url")]
    public object Url { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }
}

public class Base
{
    [JsonProperty("label")]
    public string Label { get; set; }

    [JsonProperty("ref")]
    public string Ref { get; set; }

    [JsonProperty("sha")]
    public string Sha { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    [JsonProperty("repo")]
    public Repo Repo { get; set; }
}

public class Links
{
    [JsonProperty("self")]
    public Self Self { get; set; }

    [JsonProperty("html")]
    public Html Html { get; set; }

    [JsonProperty("issue")]
    public Issue Issue { get; set; }

    [JsonProperty("comments")]
    public Comments Comments { get; set; }

    [JsonProperty("review_comments")]
    public ReviewComments ReviewComments { get; set; }

    [JsonProperty("review_comment")]
    public ReviewComment ReviewComment { get; set; }

    [JsonProperty("commits")]
    public Commits Commits { get; set; }

    [JsonProperty("statuses")]
    public Statuses Statuses { get; set; }
}

public class Self
{
    [JsonProperty("href")]
    public string Href { get; set; }
}

public class Html
{
    [JsonProperty("href")]
    public string Href { get; set; }
}

public class Comments
{
    [JsonProperty("href")]
    public string Href { get; set; }
}

public class ReviewComments
{
    [JsonProperty("href")]
    public string Href { get; set; }
}

public class ReviewComment
{
    [JsonProperty("href")]
    public string Href { get; set; }
}

public class Commits
{
    [JsonProperty("href")]
    public string Href { get; set; }
}

public class Statuses
{
    [JsonProperty("href")]
    public string Href { get; set; }
}

public class MergedBy
{
    public string login { get; set; }
    public int id { get; set; }
    public string node_id { get; set; }
    public string avatar_url { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string html_url { get; set; }
    public string followers_url { get; set; }
    public string following_url { get; set; }
    public string gists_url { get; set; }
    public string starred_url { get; set; }
    public string subscriptions_url { get; set; }
    public string organizations_url { get; set; }
    public string repos_url { get; set; }
    public string events_url { get; set; }
    public string received_events_url { get; set; }
    public string type { get; set; }
    public string user_view_type { get; set; }
    public bool site_admin { get; set; }
}

public class RequestedReviewers
{
    public string login { get; set; }
    public int id { get; set; }
    public string node_id { get; set; }
    public string avatar_url { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string html_url { get; set; }
    public string followers_url { get; set; }
    public string following_url { get; set; }
    public string gists_url { get; set; }
    public string starred_url { get; set; }
    public string subscriptions_url { get; set; }
    public string organizations_url { get; set; }
    public string repos_url { get; set; }
    public string events_url { get; set; }
    public string received_events_url { get; set; }
    public string type { get; set; }
    public string user_view_type { get; set; }
    public bool site_admin { get; set; }
}

public class Commit
{
    public string sha { get; set; }
    public Author author { get; set; }
    public string message { get; set; }
    public bool distinct { get; set; }
    public string url { get; set; }
}

public class Author
{
    public string email { get; set; }
    public string name { get; set; }
}

public class Org
{
    public int id { get; set; }
    public string login { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string avatar_url { get; set; }
}
