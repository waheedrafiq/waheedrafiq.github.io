import React from 'react';
import ReactDOM from 'react-dom/client';
import { Brain, BriefcaseBusiness, Code2, Cpu, GraduationCap, Home, Layers3, Target, UserRound } from 'lucide-react';
// @ts-ignore
import './styles.css';

type Page = {
  id: string;
  label: string;
  title: string;
  score?: number;
  eyebrow: string;
  icon: React.ReactNode;
  summary: string;
  paragraphs?: string[];
  professional?: string[];
  learning?: string[];
};

const pages: Page[] = [
  {
    id: 'home',
    label: 'Home',
    title: 'Developer Profile',
    eyebrow: 'I.T Consultant • Software Developer • Computer Vision Research',
    icon: <Home/>,
    summary: 'An I.T Consultant offering services from building networks through to writing mobile phone applications.',
    paragraphs: [
      'Certified in MCP Server 2012 and Windows 8 Workstation, with a Foundation Degree in Computer Science and a First Class BSc (Hons) in Computer Science obtained in 2017.',
      'Completed Cisco CCNA during the foundation year and worked on project work such as a KEENs project with Birmingham City University.',
      'Project-managed an ERP system for Alwayse Engineering Ltd and developed database software that helped the company reduce stock waste.',
      'Research interests include Computer Vision and OpenCV, with programming experience in C#, C/C++, ASP.NET, VB.NET and HTML.'
    ]
  },
  {
    id: 'career',
    label: 'Career Plan',
    title: 'My Career Plan',
    score: 55,
    eyebrow: 'Growth Path',
    icon: <Target />,
    summary: 'The journey started as a graduate embracing an age category many would regard as challenging, moving into junior software development with a goal to become one of the United Kingdom’s top developers.',
    paragraphs: ['Graduate → Junior Software Developer → Senior Developer → UK Top Developer']
  },
  {
    id: 'portfolio',
    label: 'Portfolio',
    title: 'Portfolio',
    score: 100,
    eyebrow: 'Developer Personal Statement',
    icon: <BriefcaseBusiness />,
    summary: 'A software developer with a strong IT consultancy and networking background, plus academic and professional experience across software, mentoring and computer vision.',
    paragraphs: [
      'Previously trained students in C/C++ at Kalamazoo with a 94% pass rate, and worked as a self-employed I.T Consultant for various local authorities across the UK, mainly in the education sector.',
      'Developed fully database-dependent websites during degree studies, graded at 100%. Second-year C# applications were graded at 89%.',
      'Developed the XploR Cane during the Foundation Degree, receiving media coverage from CNN, Wired Magazine and the Daily Mail, and winning Entrepreneur of the Year 2016.',
      'After graduating in 2017, continued learning Java, JavaScript, AngularJS and Android Development through Udemy.'
    ],
    professional: ['Customer service awareness', 'Team player', 'Ability to create, contribute and build meaningful software']
  },
  {
    id: 'education',
    label: 'Education Software',
    title: 'VB.NET Project',
    score: 90,
    eyebrow: 'Free Apps',
    icon: <GraduationCap />,
    summary: 'An English Spelling Application built from lived experience of dyslexia — designed as a powerful but simple tool for people with learning difficulties.',
    professional: ['English Spelling ABC application', 'Learning difficulty support', 'VB.NET desktop application']
  },
  {
    id: 'enterprise',
    label: 'Enterprise Software',
    title: 'C# Project',
    score: 100,
    eyebrow: 'Enterprise Sector',
    icon: <Layers3 />,
    summary: 'Enterprise software experience including an Ordering Processing System for RZ Mega Foods and Catering Services.',
    professional: ['Ordering Processing System (O.P.S)', 'C# application', 'Replaced manual receipt workflow with software-assisted order processing']
  },
  {
    id: 'ethical',
    label: 'Ethical Software',
    title: 'C# ML Projects',
    score: 90,
    eyebrow: 'Machine Learning & Robotics',
    icon: <Brain />,
    summary: 'A learning and project area focused on machine learning, robotics and ethical technology experiments in C# and computer vision.',
    learning: ['Linear Regression', 'Logistic Regression', 'Decision Tree', 'SVM', 'Naive Bayes', 'kNN', 'K-Means', 'Gaze Tracking', 'Object Detection', 'Deep Neural Network (DNN module)']
  },
  {
    id: 'opencv',
    label: 'OpenCV',
    title: 'OpenCV Skill Level',
    score: 90,
    eyebrow: 'Computer Vision',
    icon: <Cpu />,
    summary: 'OpenCV research connected to the XploR Cane smart cane project for visually impaired users.',
    paragraphs: ['During university, research and code were developed to support algorithms for the XploR Cane device.'],
    learning: ['Brute Force Matching based on ORB Algorithm', 'Contours', 'Distance Check (1)', 'Distance Check (2)', 'OpenCV Hello World using WinForms']
  },
  {
    id: 'javascript',
    label: 'JavaScript',
    title: 'JavaScript Skill Level',
    score: 90,
    eyebrow: 'Web Coding Projects',
    icon: <Code2 />,
    summary: 'A learning zone of HTML and JavaScript exercises from university and private study, growing in difficulty at each level.',
    learning: ['Working with String 1', 'Working with String 2', 'Working with Array 1', 'Validating Age', 'Loop 1–10', 'Loop 2', 'FizzBuzz', 'Iteration', 'Check Triple', 'DOM example', 'Basic JSON', 'JSON Search', 'Garage Admin', 'Garage Project']
  },
  {
    id: 'java',
    label: 'Java',
    title: 'Java Skill Level',
    score: 60,
    eyebrow: 'Object-Oriented Practice',
    icon: <Code2 />,
    summary: 'Java learning after degree completion, used to maintain and improve core programming logic.',
    learning: ['Working with Files', 'Unique Sum', 'Too Hot or Cold', 'Personal Details / Inheritance', 'Paint Wizard', 'Library Project', 'JUnit Testing', 'Java SQL', 'Java GUI', 'Garage Project', 'Black Jack', 'Java Operators']
  },
  {
    id: 'csharp',
    label: 'C#',
    title: 'C# Skill Level',
    score: 95,
    eyebrow: 'C# Code & Projects',
    icon: <Code2 />,
    summary: 'A collection of C# examples and projects covering academic assignments, desktop applications, OOP, file handling and hackathon work.',
    learning: ['XploR Cane Registration System', 'SoundDex EPIC', 'Shut Down PC', 'Polymorphism', 'Average Age', 'Extension Methods', 'Litres and Gallons', 'Inheritance and Polymorphism', 'Website assignment', 'Draw Rectangle', 'Cortana example', 'Random Application', 'Book Struct', 'Aston Hack Weekend Project', 'CRUD Example']
  },
  {
    id: 'python',
    label: 'Python',
    title: 'Python Skill Level',
    score: 90,
    eyebrow: 'Data Science & Face Recognition',
    icon: <Code2 />,
    summary: 'Python was used during degree studies to apply data science algorithms and face recognition research.',
    learning: ['Simple Face Detection / FaceRec', 'Random Lotto', 'Robotic Object Detection', 'Temperature Converter', 'Weather Update API']
  },
  {
    id: 'about',
    label: 'About Me',
    title: 'About Waheed Rafiq',
    eyebrow: 'Professional Profile',
    icon: <UserRound />,
    summary: 'A highly adaptable software professional with experience delivering applications and solving complex technical problems.',
    paragraphs: [
      'Worked in the IT industry since the age of seventeen as a self-employed contractor for companies such as Capita, Strictly Education and Kalamazoo.',
      'Has a proven ability to grasp new ideas and develop innovative solutions to complex problems.',
      'Founder-level experience through BlindX3 Ltd and Odonata Technologies Ltd, connected to the XploR smart cane project created during the Foundation Degree course.',
      'Self-motivated, diligent, and capable of working under pressure as a member of a team.'
    ]
  }
];

const navGroups = [
  { title: 'Main', items: ['home', 'career', 'portfolio'] },
  { title: 'Free Apps', items: ['education', 'enterprise', 'ethical'] },
  { title: 'Coding Projects', items: ['opencv', 'javascript', 'java', 'csharp', 'python'] },
  { title: 'Profile', items: ['about'] }
];

function App() {
  const [active, setActive] = React.useState('home');
  const page = pages.find((item) => item.id === active) ?? pages[0];
  const featured = pages.filter((item) => item.score).sort((a, b) => (b.score ?? 0) - (a.score ?? 0)).slice(0, 5);

  return (
    <main className="app-shell">
      <aside className="sidebar">
        <div className="brand-card">
          <div className="logo-wrap">
            <img src="https://waheedrafiq.github.io/images/codelogo.png" alt="Code logo" />
          </div>
          <h1>Waheed Rafiq</h1>
          <p>Developer Profile</p>
        </div>

        {navGroups.map((group) => (
          <section className="nav-group" key={group.title}>
            <h2>{group.title}</h2>
            <div className="nav-buttons">
              {group.items.map((id) => {
                const item = pages.find((pageItem) => pageItem.id === id)!;
                return (
                  <button key={id} className={active === id ? 'active' : ''} onClick={() => setActive(id)}>
                    <span>{item.icon}</span>
                    {item.label}
                  </button>
                );
              })}
            </div>
          </section>
        ))}
      </aside>

      <section className="content">
        <section className="hero">
          <div>
            <p className="eyebrow">{page.eyebrow}</p>
            <h2>{page.title}</h2>
            <p className="summary">{page.summary}</p>
          </div>
          {page.score && <SkillRing score={page.score} />}
        </section>

        {active === 'home' && (
          <figure className="photo-card">
            <img src="https://waheedrafiq.github.io/images/focus_group.png" alt="Focus group at Beacon Blind Centre" />
            <figcaption>Focus Group for the Visually Impaired at Beacon Blind Centre, connected to Waheed Rafiq’s Computer Vision research.</figcaption>
          </figure>
        )}

        <section className="detail-grid">
          <article className="panel large-panel">
            <h3>Profile Notes</h3>
            {(page.paragraphs ?? [page.summary]).map((text) => <p key={text}>{text}</p>)}
          </article>

          <article className="panel">
            <h3>Skill Snapshot</h3>
            <div className="skill-list">
              {featured.map((item) => (
                <div key={item.id} className="mini-skill">
                  <span>{item.label}</span>
                  <strong>{item.score}%</strong>
                  <div className="bar"><i style={{ width: `${item.score}%` }} /></div>
                </div>
              ))}
            </div>
          </article>
        </section>

        {(page.professional || page.learning) && (
          <section className="cards-row">
            {page.professional && <ListCard title="Professional Level" items={page.professional} />}
            {page.learning && <ListCard title="Learning Zone" items={page.learning} />}
          </section>
        )}

        <section className="timeline panel">
          <h3>Career Themes</h3>
          <div className="timeline-items">
            <span>IT Consultancy</span>
            <span>Networking</span>
            <span>C# / ASP.NET</span>
            <span>OpenCV</span>
            <span>Computer Vision</span>
            <span>Machine Learning</span>
            <span>Robotics</span>
          </div>
        </section>
      </section>
    </main>
  );
}

function SkillRing({ score }: { score: number }) {
  return (
    <div className="skill-ring" style={{ '--score': `${score * 3.6}deg` } as React.CSSProperties}>
      <div>
        <strong>{score}%</strong>
        <span>Skill Level</span>
      </div>
    </div>
  );
}

function ListCard({ title, items }: { title: string; items: string[] }) {
  return (
    <article className="panel list-card">
      <h3>{title}</h3>
      <ul>
        {items.map((item) => <li key={item}>{item}</li>)}
      </ul>
    </article>
  );
}

export default App;

ReactDOM.createRoot(document.getElementById('root')!).render(<App />);
