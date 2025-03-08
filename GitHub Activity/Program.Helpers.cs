using GitHub_Activity.Models;

public partial class Program
{
    public static void ShowEvent(Event @event)
    {
        switch (@event.Type)
        {
            case "PushEvent":
                Console.WriteLine($"Pushed {@event.Payload.Commits.Length} commits to {@event.Repo.Name}");
                break;
            case "WatchEvent":
                Console.WriteLine($"Watch was {@event.Payload.Action} to {@event.Repo.Name}");
                break;
            case "DeleteEvent":
                Console.WriteLine($"Deleted {@event.Payload.RefType} from {@event.Repo.Name}");
                break;
            case "CreateEvent":
                Console.WriteLine($"Created {@event.Payload.RefType} '{@event.Payload.Ref}' in {@event.Repo.Name}");
                break;
            case "IssueCommentEvent":
                Console.WriteLine($"Comment for Issue '{@event.Payload.Issue.Title}' was {@event.Payload.Action}");
                break;
            case "IssuesEvent":
                Console.WriteLine($"Issue '{@event.Payload.Issue.Title}' was {@event.Payload.Action}");
                break;
            case "PullRequestEvent":
                Console.WriteLine($"PullRequest was {@event.Payload.Action} with title '{@event.Payload.PullRequest.Title}'");
                break;
            default:
                Console.WriteLine($"Unknown Event Type: '{@event.Type}'");
                break;
        }
    }
}