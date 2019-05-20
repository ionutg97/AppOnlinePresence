package DTO;

public class TeacherAccountDTO {
	private String name;
	private String password;
	private String confirmPassword;
	private String fullName;

	public TeacherAccountDTO() {

	}

	public TeacherAccountDTO(String name, String password, String confirmPassword, String fullName) {
		this.name = name;
		this.password = password;
		this.confirmPassword = confirmPassword;
		this.fullName = fullName;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getConfirmPassword() {
		return confirmPassword;
	}

	public void setConfirmPassword(String confirmPassword) {
		this.confirmPassword = confirmPassword;
	}

	public String getFullName() {
		return fullName;
	}

	public void setFullName(String fullName) {
		this.fullName = fullName;
	}

}
