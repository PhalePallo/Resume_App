document.addEventListener('DOMContentLoaded', () => {
    const resumeContent = `
        <h2>John Doe</h2>
        <p>Software Developer</p>
        <h3>Contact Information</h3>
        <ul>
            <li>Email: john.doe@example.com</li>
            <li>Phone: 123-456-7890</li>
        </ul>
        <h3>Education</h3>
        <p>B.Sc. in Computer Science</p>
        <h3>Experience</h3>
        <p>3 years as a Full-Stack Developer</p>
    `;

    document.getElementById('resume').innerHTML = resumeContent;
});
