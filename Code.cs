public class TestService{
	
	private readonly IAuthService _authService;
	private readonly IArticleService _articleService;
	
	public TestService(IAuthService authService, IArticleService articleService){
		_authService = authService;
		_articleService = articleService;
	}
}