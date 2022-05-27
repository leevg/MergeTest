public class TestService{
	private readonly IAuthService _authService;
	private readonly IAdvisorService _advisorService;
	public TestService(IAuthService authService, IAdvisorService advisorService){
		_authService = authService;
		_advisorService = advisorService;
	}
}