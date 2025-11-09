import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { useEffect, useState } from 'react';
const JsonDisplay = ({ data }) => {
  return (
    <div>
      {Object.entries(data).map(([key, value]) => (
        <div key={key}>
          <strong>{key}:</strong> {JSON.stringify({ value })}
        </div>
      ))}
    </div>
  );
};
function App() {
  const URL = "http://localhost:5145/api/School";
  const [school, setSchool] = useState([]);
  useEffect(() => {
    axios.get(URL)
      .then(res => {
        setSchool(res.data);
        console.log(res.data);
      }
      ).catch(() => {
        console.log('something bad happened');
      });
  }, []);

  {

    //console.log(i.teachers[0].fullName);
    return (
      <>
        {school.map((item, index) => (
          <div key={index}>
            <span>{JSON.stringify({ item })}</span>
            <span>{item.address}</span>
          </div>
        ))}
      </>
      // school.map((i) => {
      //   return (     

      //     <h1>{i.teachers[0].fullName}</h1>
      //   );
      // }));
    );

  }

}

export default App;
