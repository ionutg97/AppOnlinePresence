package DTO;

public class TimeTableDTO {
	private String hourStart;
	private String hourEnd;
	private String teacherName;
	private String classroom;
	private String cours;
	private String laboratory;

	public TimeTableDTO() {

	}

	public TimeTableDTO(String hourStart, String hourEnd, String teacherName, String classroom, String cours,
			String laboratory) {
		this.hourStart = hourStart;
		this.hourEnd = hourEnd;
		this.teacherName = teacherName;
		this.classroom = classroom;
		this.cours = cours;
		this.laboratory = laboratory;

	}

	public String getHourStart() {
		return hourStart;
	}

	public void setHourStart(String hourStart) {
		this.hourStart = hourStart;
	}

	public String getHourEnd() {
		return hourEnd;
	}

	public void setHourEnd(String hourEnd) {
		this.hourEnd = hourEnd;
	}

	public String getTeacherName() {
		return teacherName;
	}

	public void setTeacherName(String teacherName) {
		this.teacherName = teacherName;
	}

	public String getClassroom() {
		return classroom;
	}

	public void setClassroom(String classroom) {
		this.classroom = classroom;
	}

	public String getCours() {
		return cours;
	}

	public void setCours(String cours) {
		this.cours = cours;
	}

	public String getLaboratory() {
		return laboratory;
	}

	public void setLaboratory(String laboratory) {
		this.laboratory = laboratory;
	}

}
