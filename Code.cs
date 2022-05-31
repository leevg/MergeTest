public class TestService{
	
	private readonly IAuthService _authService;
	private readonly IAdvisorService _advisorService;
	private readonly IArticleService _articleService;
	private readonly INewsService _newsServ;
	
	public TestService(IAuthService authService, IAdvisorService advisorService, IArticleService articleService, INewsService newsServ){
		_authService = authService;
		_advisorService = advisorService;
		_articleService = articleService;
		_newServ = newsServ;
	}
}