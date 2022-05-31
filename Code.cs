public class TestService{
	
	private readonly IAuthService _authService;
	private readonly IAdvisorService _advisorService;
	private readonly IArticleService _articleService;
	public TestService(IAuthService authService, IAdvisorService advisorService, IArticleService article){
		_authService = authService;
		_advisorService = advisorService;
		_articleService = articleService;
	}
}