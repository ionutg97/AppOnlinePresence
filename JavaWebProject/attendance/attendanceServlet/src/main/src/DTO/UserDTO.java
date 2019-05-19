package DTO;

public class UserDTO {
	private String UserName;
	private String Password;
	private String ConfirmPassword;

	public UserDTO() {

	}

	public UserDTO(String UserName, String Password, String ConfirmPassword) {
		this.UserName = UserName;
		this.Password = Password;
		this.ConfirmPassword = ConfirmPassword;
	}

	public String getUserName() {
		return UserName;
	}

	public void setUserName(String UserName) {
		this.UserName = UserName;
	}

	public String getPassword() {
		return Password;
	}

	public void setPassword(String Password) {
		this.Password = Password;
	}

	public String getConfirmPassword() {
		return ConfirmPassword;
	}

	public void setConfirmPassword(String ConfirmPassword) {
		this.ConfirmPassword = ConfirmPassword;
	}

}
