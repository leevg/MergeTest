public class TestService{
	
	private readonly IAuthService _authService;
	private readonly IAdvisorService _advisorService;
	private readonly IArticleService _articleService;
	private readonly INewsService _newsService;
	
	public TestService(IAuthService authService, IAdvisorService advisorService, IArticleService articleService, INewsService newsService){
		_authService = authService;
		_advisorService = advisorService;
		_articleService = articleService;
		_newService = newsService;
	}
}